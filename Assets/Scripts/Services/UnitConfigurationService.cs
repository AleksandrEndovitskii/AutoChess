﻿namespace Services
{
    public class UnitConfigurationService
    {
        public float InitialHealth { get; private set; }

        public void Initialize()
        {
            // TODO: add receiving this data from json config file
            InitialHealth = 100f;
        }
    }
}
