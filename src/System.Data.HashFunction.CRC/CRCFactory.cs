﻿using System;
using System.Collections.Generic;
using System.Text;

namespace System.Data.HashFunction.CRC
{
    /// <summary>
    /// Provides instances of implementations of <see cref="ICRC"/>.
    /// </summary>
    /// <seealso cref="ICRCFactory" />
    class CRCFactory
        : ICRCFactory
    {
        /// <summary>
        /// Creates a new <see cref="ICRC" /> instance with the default configuration.
        /// </summary>
        /// <returns>
        /// A <see cref="ICRC" /> instance.
        /// </returns>
        public ICRC Create()
        {
            return Create(CRCConfig.CRC32);
        }

        /// <summary>
        /// Creates a new <see cref="ICRC" /> instance with given configuration.
        /// </summary>
        /// <param name="config">The configuration to use.</param>
        /// <returns>
        /// A <see cref="ICRC" /> instance.
        /// </returns>
        public ICRC Create(ICRCConfig config)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));

            return new CRC_Implementation(config);
        }
    }
}
