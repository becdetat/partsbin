﻿using System;
namespace partsbin.Data
{
    /// <summary>
    /// Note that nothing is required except for the quantity, which is fine at
    /// the default of zero. Some parts might not have an appropriate package
    /// type or value, for example a dev board would just be:
    /// const arduinoDuo = new Part
    /// {
    ///     PartType = "Development board",
    ///     Range = "Arduino",
    ///     PartName = "Arduino Duo",
    ///     PartNumber = "ABC123",
    ///     Quantity = 2,
    ///     Location = "Shelf 2 Box 1"
    /// };
    /// </summary>
    public class Part
    {
        /// <summary>
        /// eg "Development board"
        /// </summary>
        public string? PartType { get; set; } = "";

        /// <summary>
        /// eg "ESP8266"
        /// </summary>
        public string? Range { get; set; } = "";

        /// <summary>
        /// eg "WiFi Mini ESP8266"
        /// </summary>
        public string? PartName { get; set; }

        /// <summary>
        /// eg. "DIP"
        /// </summary>
        public string? PackageType { get; set; }

        /// <summary>
        /// eg "0.1"
        /// </summary>
        public decimal? Value { get; set; }

        /// <summary>
        /// // eg "uF"
        /// </summary>
        public string? ValueUnit { get; set; }

        /// <summary>
        /// eg "XC3802"
        /// </summary>
        public string? PartNumber { get; set; }

        /// <summary>
        /// The quantity of this exact part (type, range, name, package type,
        /// value, unit, etc) on the shelf
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The physical location of these parts in the workshop
        /// eg "Shelf 4 Rack 2 Tray 6"
        /// </summary>
        public string? Location { get; set; }

        /// <summary>
        /// eg "Jaycar"
        /// </summary>
        public string? Manufacturer { get; set; }

        /// <summary>
        /// Documents relating to the part - eg. data sheets, programming guides
        /// </summary>
        public List<PartDocument> Documents { get; set; } = new List<PartDocument>();

        /// <summary>
        /// Suppliers for the part
        /// </summary>
        public List<Supplier> Suppliers { get; set; } = new List<Supplier>();

        public string Description => PartName ?? Range ?? PartType ?? "part";
    }
}

