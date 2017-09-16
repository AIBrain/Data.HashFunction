﻿using System;
using System.Collections.Generic;
using System.Text;

namespace System.Data.HashFunction.Blake2
{
    /// <summary>
    /// Defines a configuration for a <see cref="IBlake2B"/> implementation.
    /// </summary>
    public interface IBlake2BConfig
    {
        /// <summary>
        /// Gets the desired hash size, in bits.
        /// </summary>
        /// <value>
        /// The desired hash size, in bits.
        /// </value>
        int HashSizeInBits { get; }


        /// <summary>
        /// Gets the key.
        /// </summary>
        /// <value>
        /// The key.
        /// </value>
        byte[] Key { get; }

        /// <summary>
        /// Gets the salt.
        /// </summary>
        /// <value>
        /// The salt.
        /// </value>
        byte[] Salt { get; }

        /// <summary>
        /// Gets the personalization sequence.
        /// </summary>
        /// <value>
        /// The personalization sequence.
        /// </value>
        byte[] Personalization { get; }
    }
}
