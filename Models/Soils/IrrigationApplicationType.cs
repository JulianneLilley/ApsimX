﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Soils
{
    /// <summary>
    /// Irrigation application type
    /// </summary>
    public class IrrigationApplicationType : EventArgs
    {
        /// <summary>The amount to apply (mm).</summary>
        public double Amount;
        /// <summary>The depth of application (mm).</summary>
        public double Depth;
        /// <summary>The time to start the irrigation (hrs).</summary>
        public double StartTime;
        /// <summary>The duration of irrigation event (hrs).</summary>
        public double Duration;
        /// <summary>Whether irrigation can be intercepted by canopy.</summary>
        public bool WillIntercept;
        /// <summary>Whether irrigation can run off.</summary>
        public bool WillRunoff;
        /// <summary>The n o3</summary>
        public double NO3;
        /// <summary>The n h4</summary>
        public double NH4;
        /// <summary>The cl</summary>
        public double CL;
    }
}
