﻿namespace Microblink.Forms.Core.Recognizers
{
    public interface IHongKongIdFrontRecognizer : IRecognizer
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
        /// Defines if commercial code should be extracted from Hong Kong ID
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractCommercialCode { get; set; }
        
        /// <summary>
        /// Defines if owner's date of birth should be extracted from Hong Kong ID
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractDateOfBirth { get; set; }
        
        /// <summary>
        /// Defines if card's date of issue should be extracted from Hong Kong ID
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractDateOfIssue { get; set; }
        
        /// <summary>
        /// Defines if owner's full name should be extracted from Hong Kong ID
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractFullName { get; set; }
        
        /// <summary>
        /// Defines if owner's sex should be extracted from Hong Kong ID
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractSex { get; set; }
        
        /// <summary>
        /// Sets whether face image from ID card should be extracted
        /// 
        ///  
        ///
        /// By default, this is set to 'false'
        /// </summary>
        bool ReturnFaceImage { get; set; }
        
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
        IHongKongIdFrontRecognizerResult Result { get; }
    }

    public interface IHongKongIdFrontRecognizerResult : IRecognizerResult {
        
        /// <summary>
        /// The commerical Code of the Hong Kong ID. 
        /// </summary>
        string CommercialCode { get; }
        
        /// <summary>
        /// The date of birth of the Hong Kong ID ownder. 
        /// </summary>
        IDate DateOfBirth { get; }
        
        /// <summary>
        /// The issue date of the Hong Kong ID owner. 
        /// </summary>
        IDate DateOfIssue { get; }
        
        /// <summary>
        /// The document number of the Hong Kong card. 
        /// </summary>
        string DocumentNumber { get; }
        
        /// <summary>
        /// face image from the document if enabled with returnFaceImage property. 
        /// </summary>
        Xamarin.Forms.ImageSource FaceImage { get; }
        
        /// <summary>
        /// full document image if enabled with returnFullDocumentImage property. 
        /// </summary>
        Xamarin.Forms.ImageSource FullDocumentImage { get; }
        
        /// <summary>
        /// The full name of the Hong Kong ID owner. 
        /// </summary>
        string FullName { get; }
        
        /// <summary>
        /// The sex of the Hong Kong ID owner. 
        /// </summary>
        string Sex { get; }
        
    }
}