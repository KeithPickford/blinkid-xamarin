using System;

using UIKit;
using Foundation;
using System.Diagnostics;

using MicroBlink;

namespace iOS
{
	public partial class ViewController : UIViewController
	{
		bool isFrontCamera;
		CustomDelegate customDelegate;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			customDelegate = new CustomDelegate ();

			BlinkID.Instance().LicenseKey = "2D667DHF-R4B46TOV-OXTF2CXJ-HYSLE4UU-S7W77J72-V3XWHH33-BFDCV6VP-USDCGSR3";
			BlinkID.Instance().Delegate = customDelegate;

			BlinkID.Instance ().AddMrtdRecognizer ();
			//BlinkID.Instance ().AddMrtdCombinedRecognizer ();

			//BlinkID.Instance ().AddEudlRecognizer ();
			//BlinkID.Instance ().AddGerMrzRecognizer (); - Unavailable since iOS v2.11.0, use AddGerIDOldRecognizer
			//BlinkID.Instance ().AddGerIDOldRecognizer ();
			//BlinkID.Instance ().AddGerIDFrontRecognizer ();
			//BlinkID.Instance ().AddGerIDBackRecognizer ();
			//BlinkID.Instance ().AddGerPassportRecognizer ();
			//BlinkID.Instance ().AddGerCombinedRecognizer ();
			//BlinkID.Instance ().AddCroIdFrontRecognizer ();
			//BlinkID.Instance ().AddCroIdBackRecognizer ();
			//BlinkID.Instance ().AddCroCombinedRecognizer ();
			//BlinkID.Instance ().AddAusIDFrontRecognizer ();
			//BlinkID.Instance ().AddAusIDBackRecognizer ();
			//BlinkID.Instance ().AddAusPassportRecognizer ();
			//BlinkID.Instance ().AddAusIDCombinedRecognizer ();
			//BlinkID.Instance ().AddBarDecoderRecognizer (); - deprecated since iOS v2.11.0, use AddBarcodeRecognizer
			//BlinkID.Instance ().AddZXingRecognizer (); - deprecated since iOS v2.11.0, use AddBarcodeRecognizer
			//BlinkID.Instance ().AddBarcodeRecognizer ();
			//BlinkID.Instance ().AddCzIDFrontRecognizer ();
			//BlinkID.Instance ().AddCzIDBackRecognizer ();
			//BlinkID.Instance ().AddCzCombinedRecognizer ();

			//BlinkID.Instance ().AddMyKadRecognizer ();
			//BlinkID.Instance ().AddIKadRecognizer ();
			//BlinkID.Instance ().AddPdf417Recognizer ();
			//BlinkID.Instance ().AddSingaporeIDRecognizer ();
			//BlinkID.Instance ().AddUkdlRecognizer ();
			//BlinkID.Instance ().AddSerbIDFrontRecognizer ();
			//BlinkID.Instance ().AddSerbIDBackRecognizer ();
			//BlinkID.Instance ().AddSerbIDCombinedRecognizer ();
			//BlinkID.Instance ().AddSlovakIDFrontRecognizer ();
			//BlinkID.Instance ().AddSlovakIDBackRecognizer ();
			//BlinkID.Instance ().AddSlovakCombinedRecognizer ();
			//BlinkID.Instance ().AddSlovenianIDFrontRecognizer ();
			//BlinkID.Instance ().AddSlovenianIDBackRecognizer ();
			//BlinkID.Instance ().AddSlovenianCombinedRecognizer ();
			//BlinkID.Instance ().AddSingaporeIDFrontRecognizer ();
			//BlinkID.Instance ().AddSingaporeIDBackRecognizer ();
			//BlinkID.Instance ().AddSingaporeCombinedRecognizer ();
			//BlinkID.Instance ().AddSwissPassportRecognizer ();
			//BlinkID.Instance ().AddEudlRecognizer ();
			//BlinkID.Instance ().AddUsdlRecognizer ();
			//BlinkID.Instance ().AddAusdlRecognizer ();
			//BlinkID.Instance ().AddDedlRecognizer ();

			//BlinkID.Instance ().AddVinRecognizer ();
			//BlinkID.Instance ().AddVinParser ("VIN_PARSER_ID");
			//BlinkID.Instance ().AddLicensePlatesParser ("LICENSE_PLATES_PARSER_ID");

			//BlinkID.Instance ().AddTopUpOcrParser ("TOP_UP_OCR_PARSER_ID");
			//BlinkID.Instance ().AddRegexParser ("Blink\\d\\d\\d", "REGEX_PARSER_ID");
			//BlinkID.Instance ().AddIbanParser ("IBAN_PARSER_ID");
			//BlinkID.Instance ().AddEmailParser ("EMAIL_PARSER_ID");
			//BlinkID.Instance ().AddDateParser ("DATE_PARSER_ID");
			//BlinkID.Instance ().AddRawParser ("RAW_PARSER_ID");
			//BlinkID.Instance ().AddAmountParser ("AMOUNT_PARSER_ID");

			//BlinkID.Instance ().AddIdCardDetector ();

			//BlinkID.Instance ().ClearAllDetectors ();
			//BlinkID.Instance ().ClearAllParsers ();
			//BlinkID.Instance ().ClearAllRecognizers ();

			isFrontCamera = false;

			customDelegate.MetadataImageView = metadataImageView;
			customDelegate.MetadataTextView = metadataTextView;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void StartScanningButton_TouchUpInside (UIButton sender)
		{
			BlinkID.Instance().Scan(isFrontCamera);
		}

		class CustomDelegate : BlinkIDDelegate
		{
			public UIImageView MetadataImageView {
				get; set;
			}

			public UITextView MetadataTextView {
				get; set;
			}

			#region implemented abstract members of BlinkIDDelegate

			public override void DidOutputResults (BlinkID blinkid, NSDictionary[] results)
			{
				UIAlertView alert = new UIAlertView () { 
					Title = "BlinkID results", Message = results[0].ToString()
				};
				alert.AddButton("OK");
				alert.Show ();
			}

			public override void DidOutputImage (BlinkID blinkid, UIImage image, string name)
			{
				MetadataImageView.Image = image;
				MetadataTextView.Text = name;
			}

			#endregion
		}
	}
}

