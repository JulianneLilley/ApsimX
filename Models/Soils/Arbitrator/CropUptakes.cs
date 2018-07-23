﻿// -----------------------------------------------------------------------
// <copyright file="CropUptakes.cs" company="APSIM Initiative">
//     Copyright (c) APSIM Initiative
// </copyright>
//-----------------------------------------------------------------------
namespace Models.Soils.Arbitrator
{
    using System.Collections.Generic;
    using Models.Interfaces;

    /// <summary>
    /// A simple class for containing a single set of uptakes for a given crop.
    /// </summary>
    public class CropUptakes
    {
        /// <summary>Crop</summary>
        public IUptake Crop;

        /// <summary>List of uptakes</summary>
        public List<ZoneUptakes> Zones = new List<ZoneUptakes>();
    }
}
