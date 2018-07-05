﻿namespace Microblink.Forms.Core.Recognizers
{
    public interface IGermanyIdBackRecognizer : IRecognizer
    {
        
        /// <summary>
        /// Defines if glare detection should be turned on/off.
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool DetectGlare { get; set; }
        
        /// <summary>
        /// Defines if owner's address should be extracted from German ID
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractAddress { get; set; }
        
        /// <summary>
        /// If authority should be extracted, set this to true
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractAuthority { get; set; }
        
        /// <summary>
        /// If date of issue should be extracted, set this to true
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractDateOfIssue { get; set; }
        
        /// <summary>
        /// If eye color should be extracted, set this to true
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractEyeColour { get; set; }
        
        /// <summary>
        /// If height should be extracted, set this to true
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractHeight { get; set; }
        
        /// <summary>
        /// Image extension factors for full document image.
        /// 
        /// @see ImageExtensionFactors
        ///  
        ///
        /// By default, this is set to '{0.0f, 0.0f, 0.0f, 0.0f}'
        /// </summary>
        IImageExtensionFactors FullDocumentImageExtensionFactors { get; set; }
        
        /// <summary>
        /// Sets whether full document image of ID card should be extracted.
        /// 
        ///  
        ///
        /// By default, this is set to 'false'
        /// </summary>
        bool ReturnFullDocumentImage { get; set; }
        

        /// <summary>
        /// Gets the result.
        /// </summary>
        IGermanyIdBackRecognizerResult Result { get; }
    }

    public interface IGermanyIdBackRecognizerResult : IRecognizerResult {
        
        /// <summary>
        /// Full address 
        /// </summary>
        string Address { get; }
        
        /// <summary>
        /// City 
        /// </summary>
        string AddressCity { get; }
        
        /// <summary>
        /// House number 
        /// </summary>
        string AddressHouseNumber { get; }
        
        /// <summary>
        /// Stret name in single line 
        /// </summary>
        string AddressStreet { get; }
        
        /// <summary>
        /// ZIP code 
        /// </summary>
        string AddressZipCode { get; }
        
        /// <summary>
        /// Issuing authority of the ID 
        /// </summary>
        string Authority { get; }
        
        /// <summary>
        /// Holder's date of birth. 
        /// </summary>
        IDate DateOfBirth { get; }
        
        /// <summary>
        /// Date of expiry of the document. 
        /// </summary>
        IDate DateOfExpiry { get; }
        
        /// <summary>
        /// Date of issue 
        /// </summary>
        IDate DateOfIssue { get; }
        
        /// <summary>
        /// The document code. Document code contains two characters. For MRTD the first character
        /// shall be A, C or I. The second character shall be discretion of the issuing State or organization
        /// except that V shall not be used, and C shall not be used after A except in the crew member
        /// certificate. On machine-readable passports (MRP) first character shall be P to designate an MRP.
        /// One additional letter may be used, at the discretion of the issuing State or organization,
        /// to designate a particular MRP. If the second character position is not used for this purpose, it
        /// shall be filled by the filter character <. 
        /// </summary>
        string DocumentCode { get; }
        
        /// <summary>
        /// Unique number of the document. Document number contains up to 9 characters.
        /// Element does not exist on US Green Card. To see which document was scanned use documentType property. 
        /// </summary>
        string DocumentNumber { get; }
        
        /// <summary>
        /// Eye colour 
        /// </summary>
        string EyeColour { get; }
        
        /// <summary>
        /// full document image if enabled with returnFullDocumentImage property. 
        /// </summary>
        Xamarin.Forms.ImageSource FullDocumentImage { get; }
        
        /// <summary>
        /// Height in cm 
        /// </summary>
        string Height { get; }
        
        /// <summary>
        /// Three-letter code which indicate the issuing State.
        /// Three-letter codes are based on Alpha-3 codes for entities specified in
        /// ISO 3166-1, with extensions for certain States. 
        /// </summary>
        string Issuer { get; }
        
        /// <summary>
        /// Boolean value which denotes that MRTD result is successfully parsed. When the result is parsed, all
        /// properties below are present.
        /// 
        /// If in the PPMrtdRecognizerSettings you specified allowUnparsedResults = true, then it can happen that
        /// MRTDRecognizerResult is not parsed. When this happens, this property will be equal to true.
        /// 
        /// In that case, you can use rawOcrResult property to obtain the raw result of the OCR process, so you can
        /// implement MRTD parsing in your application.
        /// 
        ///  @return true if MRTD Recognizer result was successfully parsed and all the fields are extracted. false otherwise. 
        /// </summary>
        bool MrzParsed { get; }
        
        /// <summary>
        /// The entire Machine Readable Zone text from ID. This text is usually used for parsing
        /// other elements. 
        /// </summary>
        string MrzText { get; }
        
        /// <summary>
        /// true if all check digits inside MRZ are correct, false otherwise.
        /// More specifically, true if MRZ complies with ICAO Document 9303 standard, false otherwise. 
        /// </summary>
        bool MrzVerified { get; }
        
        /// <summary>
        /// Nationality of the holder represented by a three-letter code. Three-letter codes are based
        /// on Alpha-3 codes for entities specified in ISO 3166-1, with extensions for certain States. 
        /// </summary>
        string Nationality { get; }
        
        /// <summary>
        /// First optional data. Returns nil or empty string if not available.
        /// Element does not exist on US Green Card. To see which document was scanned use documentType property. 
        /// </summary>
        string Opt1 { get; }
        
        /// <summary>
        /// Second optional data. Returns nil or empty string if not available.
        /// Element does not exist on Passports and Visas. To see which document was scanned use documentType property. 
        /// </summary>
        string Opt2 { get; }
        
        /// <summary>
        /// Returns the primary indentifier. If there is more than one component, they are separated with space.
        /// 
        ///  @return primary id of a card holder. 
        /// </summary>
        string PrimaryId { get; }
        
        /// <summary>
        /// Returns the secondary identifier. If there is more than one component, they are separated with space.
        /// 
        ///  @return secondary id of a card holder 
        /// </summary>
        string SecondaryId { get; }
        
        /// <summary>
        /// Sex of the card holder. Sex is specified by use of the single initial, capital
        /// letter F for female, M for male or < for unspecified. 
        /// </summary>
        string Sex { get; }
        
    }
}