﻿// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rock.Web.UI.Controls
{
    /// <summary>
    /// Control that can be used to select individual parts (month, day, year) of a date
    /// </summary>
    public class DatePartsPicker : CompositeControl, IRockControl, IRockChangeHandlerControl
    {
        #region IRockControl implementation

        /// <summary>
        /// Gets or sets the label text.
        /// </summary>
        /// <value>
        /// The label text.
        /// </value>
        [
        Bindable( true ),
        Category( "Appearance" ),
        DefaultValue( "" ),
        Description( "The text for the label." )
        ]
        public string Label
        {
            get { return ViewState["Label"] as string ?? string.Empty; }
            set { ViewState["Label"] = value; }
        }

        /// <summary>
        /// Gets or sets the form group class.
        /// </summary>
        /// <value>
        /// The form group class.
        /// </value>
        [
        Bindable( true ),
        Category( "Appearance" ),
        Description( "The CSS class to add to the form-group div." )
        ]
        public string FormGroupCssClass
        {
            get { return ViewState["FormGroupCssClass"] as string ?? string.Empty; }
            set { ViewState["FormGroupCssClass"] = value; }
        }

        /// <summary>
        /// Gets or sets the help text.
        /// </summary>
        /// <value>
        /// The help text.
        /// </value>
        [
        Bindable( true ),
        Category( "Appearance" ),
        DefaultValue( "" ),
        Description( "The help block." )
        ]
        public string Help
        {
            get
            {
                return HelpBlock != null ? HelpBlock.Text : string.Empty;
            }

            set
            {
                if ( HelpBlock != null )
                {
                    HelpBlock.Text = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the warning text.
        /// </summary>
        /// <value>
        /// The warning text.
        /// </value>
        [
        Bindable( true ),
        Category( "Appearance" ),
        DefaultValue( "" ),
        Description( "The warning block." )
        ]
        public string Warning
        {
            get
            {
                return WarningBlock != null ? WarningBlock.Text : string.Empty;
            }
            set
            {
                if ( WarningBlock != null )
                {
                    WarningBlock.Text = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="RockTextBox"/> is required.
        /// </summary>
        /// <value>
        ///   <c>true</c> if required; otherwise, <c>false</c>.
        /// </value>
        [
        Bindable( true ),
        Category( "Behavior" ),
        DefaultValue( "false" ),
        Description( "Is the value required?" )
        ]
        public bool Required
        {
            get { return ViewState["Required"] as bool? ?? false; }
            set { ViewState["Required"] = value; }
        }

        /// <summary>
        /// Gets or sets the required error message.  If blank, the LabelName name will be used
        /// </summary>
        /// <value>
        /// The required error message.
        /// </value>
        public string RequiredErrorMessage
        {
            get
            {
                return RequiredFieldValidator != null ? RequiredFieldValidator.ErrorMessage : string.Empty;
            }

            set
            {
                if ( RequiredFieldValidator != null )
                {
                    RequiredFieldValidator.ErrorMessage = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets an optional validation group to use.
        /// </summary>
        /// <value>
        /// The validation group.
        /// </value>
        public string ValidationGroup
        {
            get { return ViewState["ValidationGroup"] as string; }
            set
            {
                ViewState["ValidationGroup"] = value;

                if ( CustomValidator != null )
                {
                    CustomValidator.ValidationGroup = value;
                }
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </value>
        public virtual bool IsValid
        {
            get
            {
                return !Required || RequiredFieldValidator == null || RequiredFieldValidator.IsValid;
            }
        }

        /// <summary>
        /// Gets or sets the custom validator.
        /// </summary>
        /// <value>
        /// The custom validator.
        /// </value>
        public CustomValidator CustomValidator { get; set; }

        /// <summary>
        /// Gets or sets the help block.
        /// </summary>
        /// <value>
        /// The help block.
        /// </value>
        public HelpBlock HelpBlock { get; set; }

        /// <summary>
        /// Gets or sets the warning block.
        /// </summary>
        /// <value>
        /// The warning block.
        /// </value>
        public WarningBlock WarningBlock { get; set; }

        /// <summary>
        /// Gets or sets the required field validator.
        /// </summary>
        /// <value>
        /// The required field validator.
        /// </value>
        public RequiredFieldValidator RequiredFieldValidator { get; set; }

        #endregion

        /// <summary>
        /// Gets or sets a value indicating whether [require year].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [require year]; otherwise, <c>false</c>.
        /// </value>
        public bool RequireYear
        {
            get
            {
                return ViewState["RequireYear"] as bool? ?? true;
            }

            set
            {
                ViewState["RequireYear"] = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [allow future dates].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow future dates]; otherwise, <c>false</c>.
        /// </value>
        public bool AllowFutureDates
        {
            get
            {
                return ViewState["AllowFutureDates"] as bool? ?? true;
            }

            set
            {
                ViewState["AllowFutureDates"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the future dates error message.
        /// </summary>
        /// <value>
        /// The future dates error message.
        /// </value>
        public string FutureDatesErrorMessage
        {
            get
            {
                return ViewState["FutureDaysErrorMessage"] as string ?? "Date can't be in the future";
            }

            set
            {
                ViewState["FutureDaysErrorMessage"] = value;
            }
        }

        /// <summary>
        /// Gets or sets how many years from now that the Max Year cutoff is
        /// If left blank, this will default to 50
        /// NOTE: This only applies when AllowFutureDates == True
        /// </summary>
        /// <value>
        /// The future year count.
        /// </value>
        public int? FutureYearCount
        {
            get
            {
                return ViewState["FutureYearCount"] as int?;
            }

            set
            {
                ViewState["FutureYearCount"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the start year.
        /// If left blank, this will default to 1900
        /// </summary>
        /// <value>
        /// The start year.
        /// </value>
        public int StartYear
        {
            get
            {
                return ViewState["StartYear"] as int? ?? 1900;
            }

            set
            {
                ViewState["StartYear"] = value;
            }
        }

        private DropDownList monthDropDownList;
        private DropDownList dayDropDownList;
        private DropDownList yearDropDownList;

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit( System.EventArgs e )
        {
            EnsureChildControls();
            base.OnInit( e );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatePartsPicker"/> class.
        /// </summary>
        public DatePartsPicker()
            : base()
        {
            CustomValidator = new CustomValidator();
            CustomValidator.ValidationGroup = this.ValidationGroup;

            HelpBlock = new HelpBlock();
            WarningBlock = new WarningBlock();
        }

        /// <summary>
        /// Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create any child controls they contain in preparation for posting back or rendering.
        /// </summary>
        protected override void CreateChildControls()
        {
            base.CreateChildControls();
            Controls.Clear();
            RockControlHelper.CreateChildControls( this, Controls );

            this.Attributes["data-required"] = this.Required.ToTrueFalse().ToLower();
            this.Attributes["data-requireyear"] = this.RequireYear.ToTrueFalse().ToLower();
            this.Attributes["data-allowFuture"] = this.AllowFutureDates.ToTrueFalse().ToLower();

            monthDropDownList = new DropDownList();
            monthDropDownList.CssClass = "form-control input-width-sm js-month";
            monthDropDownList.ID = "monthDropDownList_" + this.ID;
            monthDropDownList.SelectedIndexChanged += dateList_SelectedIndexChanged;

            dayDropDownList = new DropDownList();
            dayDropDownList.CssClass = "form-control input-width-sm js-day";
            dayDropDownList.ID = "dayDropDownList_" + this.ID;
            dayDropDownList.SelectedIndexChanged += dateList_SelectedIndexChanged;

            yearDropDownList = new DropDownList();
            yearDropDownList.CssClass = "form-control input-width-sm js-year";
            yearDropDownList.ID = "yearDropDownList_" + this.ID;
            yearDropDownList.SelectedIndexChanged += dateList_SelectedIndexChanged;

            Controls.Add( monthDropDownList );
            Controls.Add( dayDropDownList );
            Controls.Add( yearDropDownList );

            // add custom validator
            CustomValidator.ID = this.ID + "_cfv";
            CustomValidator.ClientValidationFunction = "Rock.controls.datePartsPicker.clientValidate";
            CustomValidator.ErrorMessage = this.Label != string.Empty ? this.Label + " cannot be a future date." : string.Empty;
            CustomValidator.CssClass = "validation-error help-inline";
            CustomValidator.Enabled = true;
            CustomValidator.Display = ValidatorDisplay.Dynamic;
            Controls.Add( CustomValidator );

            PopulateDropDowns();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the date dropdown list controls.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void dateList_SelectedIndexChanged( object sender, EventArgs e )
        {
            SelectedDatePartsChanged?.Invoke( this, e );
            ValueChanged?.Invoke( this, e );
        }

        /// <summary>
        /// Occurs when [selected date parts changed].
        /// </summary>
        public event EventHandler SelectedDatePartsChanged;

        /// <summary>
        /// Occurs when the selected value has changed
        /// </summary>
        public event EventHandler ValueChanged;

        /// <summary>
        /// Populates the drop downs.
        /// </summary>
        private void PopulateDropDowns()
        {
            EnsureChildControls();
            monthDropDownList.Items.Clear();
            monthDropDownList.Items.Add( new ListItem( string.Empty, string.Empty ) );
            DateTime date = new DateTime( 2000, 1, 1 );
            for ( int i = 0; i <= 11; i++ )
            {
                monthDropDownList.Items.Add( new ListItem( date.AddMonths( i ).ToString( "MMM" ), ( i + 1 ).ToString() ) );
            }

            dayDropDownList.Items.Clear();
            dayDropDownList.Items.Add( new ListItem( string.Empty, string.Empty ) );
            for ( int day = 1; day <= 31; day++ )
            {
                dayDropDownList.Items.Add( new ListItem( day.ToString(), day.ToString() ) );
            }

            yearDropDownList.Items.Clear();
            yearDropDownList.Items.Add( new ListItem( string.Empty, string.Empty ) );
            var maxYear = this.AllowFutureDates ? RockDateTime.Now.AddYears( this.FutureYearCount ?? 50 ).Year : RockDateTime.Now.Year;
            var minYear = this.StartYear;
            for ( int year = maxYear; year >= minYear; year-- )
            {
                yearDropDownList.Items.Add( new ListItem( year.ToString(), year.ToString() ) );
            }

            if ( this.SelectedDate.HasValue )
            {
                monthDropDownList.SelectedValue = this.SelectedDate.Value.Month.ToString();
                dayDropDownList.SelectedValue = this.SelectedDate.Value.Day.ToString();
                yearDropDownList.SelectedValue = this.SelectedDate.Value.Year.ToString();
            }
        }

        /// <summary>
        /// Outputs server control content to a provided <see cref="T:System.Web.UI.HtmlTextWriter" /> object and stores tracing information about the control if tracing is enabled.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        public override void RenderControl( HtmlTextWriter writer )
        {
            if ( this.Visible )
            {
                RockControlHelper.RenderControl( this, writer );
            }
        }

        /// <summary>
        /// Renders the base control.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public void RenderBaseControl( HtmlTextWriter writer )
        {
            bool needsAutoPostBack = SelectedDatePartsChanged != null || ValueChanged != null;
            monthDropDownList.AutoPostBack = needsAutoPostBack;
            dayDropDownList.AutoPostBack = needsAutoPostBack;
            yearDropDownList.AutoPostBack = needsAutoPostBack;

            writer.AddAttribute( "class", "form-control-group date-parts-picker js-datepartspicker" );

            writer.AddAttribute( "data-required", this.Required.ToTrueFalse().ToLower() );
            writer.AddAttribute( "data-requireyear", this.RequireYear.ToTrueFalse().ToLower() );
            writer.AddAttribute( "data-allowFuture", this.AllowFutureDates.ToTrueFalse().ToLower() );
            writer.AddAttribute( "data-itemlabel", this.Label );
            // Don't remove Id as this is required if this control is defined as attribute Field in Bulk Update
            writer.AddAttribute( "id", this.ClientID );
            writer.RenderBeginTag( HtmlTextWriterTag.Div );

            // Get date format and separater for current culture
            var dtf = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;
            string mdp = dtf.ShortDatePattern;
            var dateParts = dtf.ShortDatePattern.Split( dtf.DateSeparator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries ).ToList();
            if ( dateParts.Count() != 3 ||
                !dateParts.Any( s => s.Contains( "M" ) ) ||
                !dateParts.Any( s => s.Contains( "d" ) ) ||
                !dateParts.Any( s => s.Contains( "y" ) ) )
            {
                dateParts = new List<string> { "MM", "dd", "yyyy" };
            }

            string separatorHtml = string.Format( " <span class='separator'>{0}</span> ", dtf.DateSeparator );

            for ( int i = 0; i < 3; i++ )
            {
                string datePart = dateParts[i].ToStringSafe();

                if ( datePart.Contains( "d" ) )
                {
                    dayDropDownList.RenderControl( writer );
                }
                else if ( datePart.Contains( "M" ) )
                {
                    monthDropDownList.RenderControl( writer );
                }
                else if ( datePart.Contains( "y" ) )
                {
                    yearDropDownList.RenderControl( writer );
                }

                if ( i < 2 )
                {
                    writer.Write( separatorHtml );
                }
            }

            CustomValidator.RenderControl( writer );

            writer.RenderEndTag();
        }

        /// <summary>
        /// Gets the selected date.
        /// </summary>
        /// <value>
        /// The selected date.
        /// </value>
        public DateTime? SelectedDate
        {
            get
            {
                EnsureChildControls();
                int? selectedMonth = monthDropDownList.SelectedValueAsInt( true );
                int? selectedDay = dayDropDownList.SelectedValueAsInt( true );
                int? selectedYear = yearDropDownList.SelectedValueAsInt( true );

                if ( selectedMonth.HasValue && selectedDay.HasValue )
                {
                    // if they picked a day of the month that is invalid, just round it to last day that month;
                    int correctedDayOfMonth = Math.Min( DateTime.DaysInMonth( selectedYear ?? DateTime.MinValue.Year, selectedMonth.Value ), selectedDay.Value );

                    var date = new DateTime( ( selectedYear.HasValue ? selectedYear.Value : DateTime.MinValue.Year ), selectedMonth.Value, correctedDayOfMonth );
                    if ( !this.AllowFutureDates && date > RockDateTime.Today )
                    {
                        ShowErrorMessage( this.FutureDatesErrorMessage );
                    }
                    else
                    {
                        return date;
                    }
                }

                return null;
            }

            set
            {
                EnsureChildControls();
                if ( value != null )
                {
                    monthDropDownList.SelectedValue = value.Value.Month.ToString();
                    dayDropDownList.SelectedValue = value.Value.Day.ToString();
                    var selectedYearValue = value.Value.Year != DateTime.MinValue.Year ? value.Value.Year.ToString() : string.Empty;

                    if ( !string.IsNullOrEmpty( selectedYearValue ) && yearDropDownList.Items.FindByValue( selectedYearValue ) == null )
                    {
                        yearDropDownList.Items.Insert( 0, new ListItem( selectedYearValue, selectedYearValue ) );
                    }

                    yearDropDownList.SetValue( selectedYearValue );
                }
                else
                {
                    monthDropDownList.SelectedValue = string.Empty;
                    dayDropDownList.SelectedValue = string.Empty;
                    yearDropDownList.SelectedValue = string.Empty;
                }
            }
        }

        /// <summary>
        /// Shows the error message.
        /// </summary>
        /// <param name="errorMessage">The error message.</param>
        public void ShowErrorMessage( string errorMessage )
        {
            CustomValidator.ErrorMessage = errorMessage;
            CustomValidator.IsValid = false;
        }
    }
}