// ---------------------------------------------------------------------------
// <copyright file="CalendarEventDetails.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------

//-----------------------------------------------------------------------
// <summary>Implements the CalendarEventDetails class.</summary>
//-----------------------------------------------------------------------

namespace Microsoft.Exchange.WebServices.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents the details of a calendar event as returned by the GetUserAvailability operation.
    /// </summary>
    public sealed class CalendarEventDetails : ComplexProperty
    {
        private string storeId;
        private string subject;
        private string location;
        private bool isMeeting;
        private bool isRecurring;
        private bool isException;
        private bool isReminderSet;
        private bool isPrivate;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarEventDetails"/> class.
        /// </summary>
        internal CalendarEventDetails()
            : base()
        {
        }

        /// <summary>
        /// Attempts to read the element at the reader's current position.
        /// </summary>
        /// <param name="reader">The reader used to read the element.</param>
        /// <returns>True if the element was read, false otherwise.</returns>
        internal override bool TryReadElementFromXml(EwsServiceXmlReader reader)
        {
            switch (reader.LocalName)
            {
                case XmlElementNames.ID:
                    this.storeId = reader.ReadElementValue();
                    return true;
                case XmlElementNames.Subject:
                    this.subject = reader.ReadElementValue();
                    return true;
                case XmlElementNames.Location:
                    this.location = reader.ReadElementValue();
                    return true;
                case XmlElementNames.IsMeeting:
                    this.isMeeting = reader.ReadElementValue<bool>();
                    return true;
                case XmlElementNames.IsRecurring:
                    this.isRecurring = reader.ReadElementValue<bool>();
                    return true;
                case XmlElementNames.IsException:
                    this.isException = reader.ReadElementValue<bool>();
                    return true;
                case XmlElementNames.IsReminderSet:
                    this.isReminderSet = reader.ReadElementValue<bool>();
                    return true;
                case XmlElementNames.IsPrivate:
                    this.isPrivate = reader.ReadElementValue<bool>();
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Loads from json.
        /// </summary>
        /// <param name="jsonProperty">The json property.</param>
        /// <param name="service"></param>
        internal override void LoadFromJson(JsonObject jsonProperty, ExchangeService service)
        {
            foreach (string key in jsonProperty.Keys)
            {
                switch (key)
                {
                    case XmlElementNames.ID:
                        this.storeId = jsonProperty.ReadAsString(key);
                        break;
                    case XmlElementNames.Subject:
                        this.subject = jsonProperty.ReadAsString(key);
                        break;
                    case XmlElementNames.Location:
                        this.location = jsonProperty.ReadAsString(key);
                        break;
                    case XmlElementNames.IsMeeting:
                        this.isMeeting = jsonProperty.ReadAsBool(key);
                        break;
                    case XmlElementNames.IsRecurring:
                        this.isRecurring = jsonProperty.ReadAsBool(key);
                        break;
                    case XmlElementNames.IsException:
                        this.isException = jsonProperty.ReadAsBool(key);
                        break;
                    case XmlElementNames.IsReminderSet:
                        this.isReminderSet = jsonProperty.ReadAsBool(key);
                        break;
                    case XmlElementNames.IsPrivate:
                        this.isPrivate = jsonProperty.ReadAsBool(key);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the store Id of the calendar event.
        /// </summary>
        public string StoreId
        {
            get { return this.storeId; }
        }

        /// <summary>
        /// Gets the subject of the calendar event.
        /// </summary>
        public string Subject
        {
            get { return this.subject; }
        }

        /// <summary>
        /// Gets the location of the calendar event.
        /// </summary>
        public string Location
        {
            get { return this.location; }
        }

        /// <summary>
        /// Gets a value indicating whether the calendar event is a meeting.
        /// </summary>
        public bool IsMeeting
        {
            get { return this.isMeeting; }
        }

        /// <summary>
        /// Gets a value indicating whether the calendar event is recurring.
        /// </summary>
        public bool IsRecurring
        {
            get { return this.isRecurring; }
        }

        /// <summary>
        /// Gets a value indicating whether the calendar event is an exception in a recurring series.
        /// </summary>
        public bool IsException
        {
            get { return this.isException; }
        }

        /// <summary>
        /// Gets a value indicating whether the calendar event has a reminder set.
        /// </summary>
        public bool IsReminderSet
        {
            get { return this.isReminderSet; }
        }

        /// <summary>
        /// Gets a value indicating whether the calendar event is private.
        /// </summary>
        public bool IsPrivate
        {
            get { return this.isPrivate; }
        }
    }
}
