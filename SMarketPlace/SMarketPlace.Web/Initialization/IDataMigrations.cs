﻿namespace SMarketPlace
{
    public interface IDataMigrations
    {
        bool SkippedMigrations { get; }

        void Initialize();
    }
}