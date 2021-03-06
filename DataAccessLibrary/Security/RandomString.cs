﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DataAccessLibrary.Security
{
    /// <summary>
    /// Generator for API client secrets.
    /// </summary>
    class RandomString
    {
        /// <summary>
        /// Generates a secure random string for use as a secure secret.
        /// </summary>
        /// <param name="length">Length of secret. Defaults to 32.</param>
        /// <returns></returns>
        public static string GenerateCrypto(int length = 32)
        {
            RandomNumberGenerator cryptoRandomDataGenerator = new RNGCryptoServiceProvider();

            byte[] buffer = new byte[length];

            cryptoRandomDataGenerator.GetBytes(buffer);

            string secret = Convert.ToBase64String(buffer);

            return secret;
        }

        public static string GeneratePseudo(int length = 11)
        {
            Random rng = new Random();
            string secret = "";

            for (int i = 0; i < length; i++)
            {
                switch (rng.Next(1, 4))
                {
                    case 1:
                        secret += (char)rng.Next(65, 91);
                        break;
                    case 2:
                        secret += (char)rng.Next(97, 123);
                        break;
                    case 3:
                        secret += (char)rng.Next(48, 58);
                        break;
                }
            }

            return secret;
        }
    }
}
