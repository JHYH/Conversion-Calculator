/*
 * The program will display a list of possible options, read in the user’s choice,
 * display the available conversions and then perform the required calculation or action.
 * The user will be able to select any option from a menu and the program will be able to handle the situation gracefully.
 *      
 * Author: Yung-Hua Hsiao
 * Date:   March 2014 
 * 
 * This Conversion Calculator (CC) will permit the user to choose from the following main menu:
 *  
 * 1.Length calculator
 * 2.Body Mass Index calculator
 * 3.Waist to Height calculator
 * 4.Fuel Consumption calculator
 * 5.Exit the calculator
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INN270_ProgramingAssighment1 {
    class ConversionCalculator {

        /// <summary>
        /// Perform LengthCalculator 
        /// Pre:  Main menu option input = 1 (Length Calculator) 
        /// Post: Performed Length Calculator
        /// </summary>
        /// <param name="LengthCalculatorOption">To Determine what is user's input</param>
        /// <param name="AnotherLengthConversion"> Do while loop condition</param>
        /// return value: LengthCalculatorOption
        static int LengthCalculator() {

            int LengthCalculatorOption;

            string AnotherLengthConversion = null;

            do {
                LengthCalculatorMenu();
                LengthCalculatorOption = ValidLengthCalculatorReadOption();
                AnotherLengthConversion = Console.ReadLine();
            } while (AnotherLengthConversion == "Y" || AnotherLengthConversion == "y");// End Do While loop. If AnotherLengthConversion = "Y" OR "y", start the do while loop 

            return LengthCalculatorOption;

        }//End LenthCalculator

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Read the  Centimetres(cm) that enter by user then Convert Centimetres To Feet And Inches
        /// Pre: LengthCalculatorOption == 1
        /// Post: Performed ConvertCentimetresToFeetAndInches()
        /// </summary>
        /// <param name="Centimetres"/> Get the centimetres that user want to conver</param>
        /// <param name="Feet"/> For convertsion Calculation</param> 
        /// <param name="Inches"/> For convertsion Calculation</param> 
        /// <param name="TotalInches"/> For convertsion Calculation</param> 
        /// <param name="CENTIMETRES_PER_INCH"/> Centimetres per inch = 2.54</param> 
        /// <param name="INCHES_PER_FOOT"/> Inches per foot = 12</param>
        /// return value: No return Value
        static void ConvertCentimetresToFeetAndInches() {
            double Centimetres = 0.0, Feet = 0.0, Inches = 0.0, TotalInches = 0.0;
            const double CENTIMETRES_PER_INCH = 2.54, INCHES_PER_FOOT = 12;

            Console.WriteLine("Please Enter the Centimetres(cm) that you wish to convert to feet and inches:");
            Centimetres = double.Parse(Console.ReadLine());
            TotalInches = (Centimetres / CENTIMETRES_PER_INCH); // This will take a floor function of Centimetres/2.54
            Feet = (TotalInches - TotalInches % INCHES_PER_FOOT) / INCHES_PER_FOOT; // This will make it divisible by 12
            Inches = TotalInches % INCHES_PER_FOOT; // This will give you the remainder after you divide by 12
            Console.WriteLine("\nThe equivalent in feet and inches is {0} ft {1} ins", Feet, Inches);

        }// End ConvertCentimetresToFeetAndInches

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Read the Feet and Inches enter by user then Convert Feet and Inches to Centimetres
        /// Pre:  LengthCalculatorOption == 2
        /// Post: Performed ConvertFeetAndInchesToCentimetres
        /// </summary>
        /// <param name="Centimetres"/> For Conversion Calculation</param>
        /// <param name="Feet"/> Get the Feet that user want to conver</param> 
        /// <param name="Inches"/> Get the Inches that user want to conver</param> 
        /// <param name="CENTIMETRES_PER_INCH"/> Centimetres per inch = 2.54 For Conversion Calculation</param>
        /// <param name="INCHES_PER_FOOT"/> Inches per foot = 12  For Conversion Calculation
        /// return value: No return Value

        static void ConvertFeetAndInchesToCentimetres() {
            int Feet, Inches;
            double Centimetres = 0.0;
            const double CENTIMETRES_PER_INCH = 2.54, INCHES_PER_FOOT = 12;

            Console.WriteLine("Please Enter the Feet:");
            Feet = int.Parse(Console.ReadLine()); // Get the Feet that user want to conver 
            Console.WriteLine("Please Enter the Inches:");
            Inches = int.Parse(Console.ReadLine()); // Get the Inches that user want to conver 
            Centimetres = ((Feet * INCHES_PER_FOOT) + Inches) * CENTIMETRES_PER_INCH; //Calculation for convert Feet an Inches to Centimetres
            Console.WriteLine("The equivalent in centimetres is {0}cm", Centimetres);

        }//End ConvertFeetAndInchesToCentimetres

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Display the Length Calculator Menu
        /// Pre:  Main menu option input = 1 (Length Calculator) 
        /// Post: LengthCalculatorMenu Displayed
        /// </summary>
        /// <paramref name="LengthCalculatorMenu"/> SubMenu for LengthCalculator/param>
        /// return value:
        static void LengthCalculatorMenu() {
            string LengthCalculatorMenu = ("Enter 1) Convert Centimetres to Feet and Inches:"
                                        + "\nEnter 2) Convert feet and inches to centimetres:"
                                        + "\nEnter 3) Cancel this Option And Return to Main Menu:");
            Console.Write(LengthCalculatorMenu);
        }//End LengthCalculatorMenu

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Read and perform user's input option and also allow user to enter the valid input for Length Calculator 
        /// Pre: true or BMICalculatorOption is eithr 1, 2 or 3
        /// Post: Read the user's input option and performed option either 1, 2 or 3 
        /// </summary>
        /// <paramref name="LengthCalculatorOption"/> Read the input for user's option/param> 
        /// <paramref name="ValidLengthCalculatorOption"/> Determine the validation of input for user's option/param>
        /// return value : LengthCalculatorOption
        static int ValidLengthCalculatorReadOption() {

            int LengthCalculatorOption = 0;
            bool ValidLengthCalculatorOption = false;

            do {
                LengthCalculatorOption = int.Parse(Console.ReadLine());

                if ((LengthCalculatorOption >= 1) && (LengthCalculatorOption <= 3)) {
                    ValidLengthCalculatorOption = true;
                } else {
                    ValidLengthCalculatorOption = false;
                } // end if

                if (!ValidLengthCalculatorOption) {
                    Console.WriteLine("\n\t Option must be 1, 2 or 3. Please Re-Enter your Option");
                    LengthCalculatorMenu();
                } //end if 

                if (LengthCalculatorOption == 1) { // Do this code if LengthCalculatorOption input == 1 
                    ConvertCentimetresToFeetAndInches();
                    Console.Write("\nWould you like to make an another Length conversion?"
                                 + "\n\n(Enter [Y] to make an another conversion/Enter [N] return to Main menu):");
                } else if (LengthCalculatorOption == 2) { // Do this code if LengthCalculatorOption input == 2
                    ConvertFeetAndInchesToCentimetres();
                    Console.Write("\nWould you like to make an another Length conversion?"
                                 + "\n\n(Enter [Y] to make an another conversion/Enter [N] return to Main menu):");
                } else if (LengthCalculatorOption == 3) { // Do this code if LengthCalculatorOption input == 3
                    Console.Write("\nYour Current Option has been Cancelled"); //Selection cancelled message
                    Main();
                } //End if

            } while (!ValidLengthCalculatorOption); //End  Do While loop

            return LengthCalculatorOption;
        }// End LengthCalculatorReadOption

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Perform BMI Calculator 
        /// Pre:  Main Menu option input = 2 (BMICalculator) 
        /// Post: BMICalculator Performed
        /// </summary>
        /// <param name="BMICalculatorOption">To Determine what is user's input for BMI Calculator</param>
        /// <param name="AnotherBMIConversion"> Do while loop condition for BMI Calculator</param>
        /// return value: LengthCalculatorOption
        static int BMICalculator() {

            int BMICalculatorOption;
            string AnotherBMIConversion = null;

            do {
                BMICalculatorMenu();
                BMICalculatorOption = ValidBMICalculatorReadOption();
                AnotherBMIConversion = Console.ReadLine();

            } while (AnotherBMIConversion == "Y" || AnotherBMIConversion == "y");

            return BMICalculatorOption;
        } //End BMI Calculator

        /// <summary>
        /// Display the BMI Calculator Menu
        /// Pre:  Main menu option input = 2 (BMICalculator) 
        /// Post: BMI Calculator Menu Displayed
        /// </summary>
        /// <paramref name="BMIMenu"/> SubMenu for BMI Calculator</param>
        /// return value: No return value
        static void BMICalculatorMenu() {
            string BMIMenu = ("Which Measurement You Want to use to enter the weight and height?"
                                + "\nEnter 1) for Metric"
                                + "\nEnter 2) for British Imperial"
                                + "\nEnter 3) Cancel this Option And Return to Main Menu:");
            Console.Write(BMIMenu);
        } //End BMIMenu

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Perform BMI Calculator In Metric measurement, read the Weight and Height in metric enter by user then perform BMI Calculation
        /// Pre:  BMIOption == 1
        /// Post: Performed  BMI Calculator In Metric measurement
        /// </summary>
        /// <param name="WeightKg"/> Get the user's weight in kg then use for BMI Calculation</param>
        /// <param name="HeightCm"/> Get the user's hight in cm then use for BMI Calculation</param>
        /// <param name="MeterPerCentimetres"/> Meter per MeterPerCentimetres = 100cm . It is for BMI calculation</param> 
        /// <param name="BMI"/> The result for BMI calculation</param> 
        /// return value: No return Value
        static void BMIOptionMetric() {
            double WeightKg = 0.0, HeightCm = 0.0, BMI = 0.0;
            const int Meter_Per_Centimetres = 100;

            Console.Write("\nPlease Enter your Weight in Kilogram (kg):");
            WeightKg = double.Parse(Console.ReadLine());
            Console.Write("\nPlease Enter your Height in in centimetres (cm):");
            HeightCm = double.Parse(Console.ReadLine());

            BMI = WeightKg / (HeightCm / Meter_Per_Centimetres * HeightCm / Meter_Per_Centimetres); // Formula for BMI Calculation

            if (BMI >= 35.0) {
                Console.WriteLine("\nYour BMI is {0:G},Severe Obesity", BMI);
            } else if (BMI >= 30.0) {
                Console.WriteLine("\nYour BMI is {0:G},Obese", BMI);
            } else if (BMI >= 25.0) {
                Console.WriteLine("\nYour BMI is {0:G},OverWeight", BMI);
            } else if (BMI >= 18.5) {
                Console.WriteLine("\nYour BMI is {0:G},Healthy BodyWeight", BMI);
            } else if (BMI <= 18.5) {
                Console.WriteLine("\nYour BMI is {0:G},UnderWeight", BMI);
            }//End if

        } //End BMIOptionMetric

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Perform BMI Calculator In British Imperial, read the Weight and Height in British Imperial enter by user then perform BMI Calculation
        /// Pre:  BMIOption == 2
        /// Post: Performed  BMI Calculator In British Imperial
        /// </summary>
        /// <param name="Weightlbs"/> Get the user's weight in pound then use for BMI Calculation</param>
        /// <param name="WeightOz"/> Get the user's weight in ounces then use for BMI Calculation</param>
        /// <param name="Feet"/> Get the user's hight in feet then use for BMI Calculation</param> 
        /// <param name="Inches"/> Get the user's hight in Inches then use for BMI Calculation</param> 
        /// <param name="CENTIMETRES_PER_INCH"/> Centimetres per inch = 2.54 For BMI Calculation</param>
        /// <param name="INCHES_PER_FOOT"/> Inches per foot = 12  For BMI Calculation</param>
        /// <param name="Thousand_Grams_Per_Ounce"/> 1000 Grams per ounces = 35.2  For BMI Calculation</param>
        /// <param name="MeterPerCentimetres"/> Meter per MeterPerCentimetres = 100cm . It is for BMI calculation</param> 
        /// <param name="Ounces_Per_Pound"/> Meter per MeterPerCentimetres = 16 . It is for BMI calculation</param>
        /// <param name="BMI"/> The result for BMI calculation</param> 
        /// <param name="WeightKg"/> Get the user's weight in kg then use for BMI Calculation</param>
        /// <param name="HeightCm"/> Get the user's hight in cm then use for BMI Calculation</param>
        /// return value: No return Value
        static void BMIOptionBritishImperial() {
            double WeightKg = 0.0, HeightCm = 0.0, Weightlbs = 0.0, WeightOz = 0.0, BMI = 0.0, Feet = 0.0, Inches = 0.0;
            const int Ounces_Per_Pound = 16, Meter_Per_Centimetres = 100, INCHES_PER_FOOT = 12;
            const double Thousand_Grams_Per_Ounce = 35.2, CENTIMETRES_PER_INCH = 2.54;


            Console.WriteLine("Please Enter your Weight in Pounds (lbs):");
            Weightlbs = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter your Weight in Ounces (oz):");
            WeightOz = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter your Height in Feet (ft):");
            Feet = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter your Height in Inches (ins):");
            Inches = double.Parse(Console.ReadLine());

            WeightKg = ((Weightlbs * Ounces_Per_Pound) + WeightOz) / Thousand_Grams_Per_Ounce; // Calculation for Convert pounds and Ounces to Kg
            HeightCm = ((Feet * INCHES_PER_FOOT) + Inches) * CENTIMETRES_PER_INCH; // Calculation for Convert Feet and Inches to Cm
            BMI = WeightKg / (HeightCm / Meter_Per_Centimetres * HeightCm / Meter_Per_Centimetres); //BMI Calculation

            if (BMI >= 35) {
                Console.WriteLine("Your BMI is {0:G},Severe Obesity", BMI);
            } else if (BMI >= 30) {
                Console.WriteLine("Your BMI is {0:G},Obese", BMI);
            } else if (BMI >= 25) {
                Console.WriteLine("Your BMI is {0:G},OverWeight", BMI);
            } else if (BMI >= 18.5) {
                Console.WriteLine("Your BMI is {0:G},Healthy BodyWeight", BMI);
            } else if (BMI <= 18.5) {
                Console.WriteLine("Your BMI is {0:G},UnderWeight", BMI);
            } //End if

        } // End BMIOptionBritishImperial()

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Read and perform user's input option and also allow user to enter the valid input for BMI Calculator
        /// Pre: true or BMICalculatorOption is eithr 1, 2 or 3
        /// Post: Read the user's input option and performed option either 1, 2 or 3 
        /// </summary>
        /// <paramref name="BMICalculatorOptionOption"/> Read the input for user's option</param> 
        /// <paramref name="ValidBMICalculatorOption"/> Determine the validation of input for user's option</param>
        /// return value : ValidBMICalculatorReadOption
        static int ValidBMICalculatorReadOption() {

            int BMICalculatorOption;
            bool ValidBMICalculatorOption = false;

            do {
                BMICalculatorOption = int.Parse(Console.ReadLine());

                if ((BMICalculatorOption >= 1) && (BMICalculatorOption <= 3)) {
                    ValidBMICalculatorOption = true;
                } else {
                    ValidBMICalculatorOption = false;
                } //End if

                if (!ValidBMICalculatorOption) {
                    Console.WriteLine("\n\t Option must be 1, 2 or 3");
                    BMICalculatorMenu();
                } //End if 

                if (BMICalculatorOption == 1) { // Do this code if BMIOption input == 1 
                    BMIOptionMetric();
                    Console.Write("\nWould you like to make an another BMI conversion? \n\n(Enter [Y] to make an another conversion/Enter [N] return to Main menu):");
                } else if (BMICalculatorOption == 2) { // Do this code if BMIOption input == 2 
                    BMIOptionBritishImperial();
                    Console.Write("\nWould you like to make an another BMI conversion? \n\n(Enter [Y] to make an another conversion/Enter [N] return to Main menu):");
                } else if (BMICalculatorOption == 3) { // Do this code if BMIOption input == 3 
                    Console.Write("\nYour Current Option has been Cancelled"); //Selection cancelled message
                    Main();
                } // End if 



            } while (!ValidBMICalculatorOption); // End Do while loop

            return BMICalculatorOption;
        } //End ValidBMICalculatorReadOption

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Perform Waist To Height Calculator
        /// Pre:  Main menu option input = 3 (Waist To Height Calculator) 
        /// Post: Performed Waist To Height Calculator
        /// </summary>
        /// <param name="WaistToHeightCalculatorOption">To Determine what is user's input</param>
        /// <param name="AnotherWaistToHeightConversion"> Do while loop condition</param>
        /// return value: WaistToHeightCalculatorOption
        static int WaistToHeightCalculator() {
            int WaistToHeightCalculatorOption;
            string AnotherWaistToHeightConversion = null;

            do {
                WaistToHeightCalculatorMenu();
                WaistToHeightCalculatorOption = ValidWaistToHeightCalculatorReadOption();
                AnotherWaistToHeightConversion = Console.ReadLine();

            } while (AnotherWaistToHeightConversion == "Y" || AnotherWaistToHeightConversion == "y");
            return WaistToHeightCalculatorOption;
        }// End 

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Display the Waist To Height Calculator Menu
        /// Pre:  Main menu option input = 3 (WaistToHeightCalculator) 
        /// Post: WaistToHeightCalculatorMenu Displayed
        /// </summary>
        /// <paramref name="WaistToHeightCalculatorMenu"/> Menu for Waist To Height Calculator</param>
        /// return value: no return value
        static void WaistToHeightCalculatorMenu() {
            string WaistToHeightCalculatorMenu = ("\nWhich Measurement You Want to use to enter the Waist and Height?"
                                                   + "\n1)Enter 1 for Metric"
                                                   + "\n2)Enter 2 for British Imperial:"
                                                   + "\n3)Enter 3 Cancel this Option And Return to Main Menu:");
            Console.Write(WaistToHeightCalculatorMenu);

        } // End WaistToHeightCalculatorMenu()

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Perform Waist To Height Calculator In Metric measurement, read the Height and Waist in Metric enter by user then perform WaistToHeight Calculation
        /// Pre:  WaistToHeightCalculatorOption == 1
        /// Post: Performed  Waist To Height Calculator In Metric measurement 
        /// </summary>
        /// <param name="HeightCm"/> Get the user's hight in cm then use for Waist To Height Ratio Calculation</param>
        /// <param name="WaistCm"/> Get the user's waist in cm then use for Waist To Height Ratio Calculation</param>
        /// <param name="WaistToHeightRatio"/> Result for Waist To Height Calculator</param>
        /// <param name="GenderOption"/>  Get the user's gender</param>
        /// return value: No return Value
        static void WaistToHeightOptionMetric() {

            double HeightCm = 0.0, WaistCm = 0.0, WaistToHeightRatio = 0.0;
            int GenderOption;

            Console.Write("\nPlease Enter your Height in cm:");
            HeightCm = double.Parse(Console.ReadLine());
            Console.Write("\nPlease Enter your Waist in centimetres (cm):");
            WaistCm = double.Parse(Console.ReadLine());

            WaistToHeightRatio = WaistCm / HeightCm;
            Console.Write("\n1)Enter 1 If you are Male"
                        + "\n2)Enter 2 If you are Female:");

            GenderOption = ValidGenderOption();

            if (GenderOption == 1 && WaistToHeightRatio >= 0.536) {
                Console.Write("\nYour Waist to Height Ration is {0}, Your Risk of Obesity Related Cardiovascular Diseases is at Risk", WaistToHeightRatio);
            } else if (GenderOption == 1 && WaistToHeightRatio < 0.536) {
                Console.Write("\nYour Waist to Height Ration is {0}, Your Risk of Obesity Related Cardiovascular Diseases is at low Risk", WaistToHeightRatio);
            } else if (GenderOption == 2 && WaistToHeightRatio >= 0.492) {
                Console.Write("\nYour Waist to Height Ration is {0}, Your Risk of Obesity Related Cardiovascular Diseases is at Risk", WaistToHeightRatio);
            } else if (GenderOption == 2 && WaistToHeightRatio < 0.492) {
                Console.Write("\nYour Waist to Height Ration is {0}, Your Risk of Obesity Related Cardiovascular Diseases is at low Risk", WaistToHeightRatio);
            } //End if

        } // End WaistToHeightOptionMetric

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Perform Waist To Height Calculator In British Imperial measurement , read the Height and Waist in BritishImperial enter by user then perform WaistToHeight Calculation
        /// Pre:  WaistToHeightCalculatorOption == 2
        /// Post: Performed  Waist To Height Calculator In British Imperial measurement 
        /// </summary>
        /// <param name="WaistIns"/> Get the user's Waist in inch then use for Waist To Height Ratio Calculation</param>
        /// <param name="HeightFeet"/> Get the user's Height in feet then use for Waist To Height Ratio Calculation</param>
        /// <param name="HeightIns"/> Get the user's Height in inch then use for Waist To Height Ratio Calculation</param>
        /// <param name="GenderOption"/>  Get the user's gender</param> 
        /// return value: No return Value
        static void WaistToHeightOptionBritishImperial() {
            double WaistIns = 0.0, HeightFeet = 0.0, HeightIns = 0.0, HeightTotalInIns = 0.0, WaistToHeightRatio = 0.0;
            int GenderOption;

            Console.Write("\nPlase Enter your Waist in inches:");
            WaistIns = double.Parse(Console.ReadLine());
            Console.Write("\nPlease Enter the Height in feet:");
            HeightFeet = double.Parse(Console.ReadLine());
            Console.Write("\nPlease Enter the Height in inches:");
            HeightIns = double.Parse(Console.ReadLine());

            Console.Write("\nMale Enter 1 , Female Enter 2:");
            GenderOption = ValidGenderOption();

            HeightTotalInIns = (HeightFeet * 12) + HeightIns;
            WaistToHeightRatio = WaistIns / HeightTotalInIns;

            if (GenderOption == 1 && WaistToHeightRatio >= 0.536) {
                Console.Write("Your Waist to Height Ration is {0}, Your Risk of Obesity Related Cardiovascular Diseases is at High Risk", WaistToHeightRatio);
            } else if (GenderOption == 1 && WaistToHeightRatio < 0.536) {
                Console.Write("Your Waist to Height Ration is {0}, Your Risk of Obesity Related Cardiovascular Diseases is at low Risk", WaistToHeightRatio);
            } else if (GenderOption == 2 && WaistToHeightRatio >= 0.492) {
                Console.Write("Your Waist to Height Ration is {0}, Your Risk of Obesity Related Cardiovascular Diseases is at High Risk", WaistToHeightRatio);
            } else if (GenderOption == 2 && WaistToHeightRatio < 0.492) {
                Console.Write("Your Waist to Height Ration is {0}, Your Risk of Obesity Related Cardiovascular Diseases is at low Risk", WaistToHeightRatio);
            } //End if

        } //End WaistToHeightOptionBritishImperia

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Allow user to enter valid input for Gender Option
        /// Pre: true
        /// Post: return option whose value is either 1, 2 or 3 
        /// </summary>
        /// <paramref name="GenderOption"/> Read the input for user's gender option</param> 
        /// <paramref name="ValidGenderOption"/> To Determine the validation of input for user's gender option</param>
        /// return value : ValidBMICalculatorReadOption
        static int ValidGenderOption() {

            int GenderOption;
            bool ValidGenderOption = false;

            do {
                GenderOption = int.Parse(Console.ReadLine());

                if ((GenderOption >= 1) && (GenderOption <= 2)) {
                    ValidGenderOption = true;
                } else {
                    ValidGenderOption = false;
                } //End if 

                if (!ValidGenderOption) {
                    Console.WriteLine("\n\t Option must be 1 or 2");
                    Console.Write("\nMale Enter 1 , Female Enter 2:");
                }// End if

            } while (!ValidGenderOption);

            return GenderOption;

        } // End ValidGenderOption


        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Read and perform user's input option and also allow user to enter the valid input for Waist To Height Calculator 
        /// Pre: true or aistToHeightCalculatorOption is eithr 1, 2 or 3
        /// Post: Read the user's input option and performed option either 1, 2 or 3 
        /// </summary>
        /// <paramref name="WaistToHeightCalculatorOption"/> Read the input for user's option</param> 
        /// <paramref name="ValidWaistToHeightCalculatorOption"/> Determine the validation of input for user's option</param>
        /// return value : ValidBMICalculatorReadOption
        static int ValidWaistToHeightCalculatorReadOption() {

            int WaistToHeightCalculatorOption;
            bool ValidWaistToHeightCalculatorOption = false;

            do {
                WaistToHeightCalculatorOption = int.Parse(Console.ReadLine());

                if ((WaistToHeightCalculatorOption >= 1) && (WaistToHeightCalculatorOption <= 3)) {
                    ValidWaistToHeightCalculatorOption = true;
                } else {
                    ValidWaistToHeightCalculatorOption = false;
                } //End if

                if (!ValidWaistToHeightCalculatorOption) {
                    Console.WriteLine("\n\t Option must be 1, 2 or 3");
                    BMICalculatorMenu();
                } //End if 

                if (WaistToHeightCalculatorOption == 1) { //Do this code if WaistToHeightCalculatorOptio input == 1 
                    WaistToHeightOptionMetric();
                    Console.Write("\nWould you like to make an another Waist To Height Calculation? \n\n(Enter [Y] to make an another conversion/Enter [N] return to Main menu):");
                } else if (WaistToHeightCalculatorOption == 2) { //Do this code if WaistToHeightCalculatorOptio input == 2 
                    WaistToHeightOptionBritishImperial();
                    Console.Write("\nWould you like to make an another Waist To Height Calculation? \n\n(Enter [Y] to make an another conversion/Enter [N] return to Main menu):");
                } else if (WaistToHeightCalculatorOption == 3) { //Do this code if WaistToHeightCalculatorOptio input == 3 
                    Console.Write("\nYour Current Option has been Cancelled"); //Selection cancelled message
                    Main();
                } // End if 

            } while (!ValidWaistToHeightCalculatorOption);

            return WaistToHeightCalculatorOption;
        } //End ValidBMICalculatorReadOption

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Perform Fuel Consumption Calculator
        /// Pre:  Main menu option input = 4 (Waist To Height Calculator) 
        /// Post: Performed Fuel Consumption Calculator
        /// </summary>
        /// <param name="FuelConsumptionMenuOption">To Determine what is user's input </param>
        /// <param name="AnotherFuelConsumptionConversion"> Do while loop condition </param>
        /// return value: FuelConsumptionMenuOption
        static int FuelConsumptionCalculator() {
            int FuelConsumptionMenuOption;
            string AnotherFuelConsumptionConversion = null;

            do {
                FuelConsumptionMenu();
                FuelConsumptionMenuOption = ValidFuelConsumptionMenuReadOption();
                AnotherFuelConsumptionConversion = Console.ReadLine();
            } while (AnotherFuelConsumptionConversion == "Y" || AnotherFuelConsumptionConversion == "y");
            return FuelConsumptionMenuOption;
        } //End FuelConsumptionCalculator

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Display the Fuel Consumption Menu 
        /// Pre:  Main menu option input = 4 (FuelConsumptionCalculator) 
        /// Post: Fuel Consumption Menu Displayed
        /// </summary>
        /// <paramref name="FuelConsumptionMenu"/> Menu for FuelConsumptionCalculator</param>
        /// return value: no return value
        static void FuelConsumptionMenu() {
            string FuelConsumptionMenu = ("\nWhich Measurement You Want to use?:"
                                       + "\n1)Enter 1)For Metric"
                                       + "\n2)Enter 2)For British Imperial:"
                                       + "\n3)Enter 3)Cancel this Option And Return to Main Menu:");
            Console.Write(FuelConsumptionMenu);

        } // End FuelConsumptionMenu

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Perform Fuel Consumption Calculator In Metric measurement,read the Litres used and Kilometres driven in metric, enter by user then perform WaistToHeight Calculation
        /// Pre:  FuelConsumptionMenuOption == 1
        /// Post: Performed  Fuel Consumption Calculator In Metric measurement 
        /// </summary>
        /// <param name="Litre"/> Get the Litres(l) of Fuel used over distance travelled for fuel consumption Calculation</param>
        /// <param name="Kilometre"/> Get the Kilometres driven for Waist for fuel consumption Calculation</param>
        /// <param name="ComsumptionPer100Km"/> For litres per 100 kilometres (1/100km) Calculation</param>
        /// <param name="EquivalentResultInMPG"/>  For The equivalent result in miles per gallon</param>
        /// <param name="MilePerKilometres"/> Mile per Kilometres is 1.609, used in fuel consumption calculation</param>
        /// <param name="GallonPerLitres"/>  Gallon per litres is 4.546, used in fuel consumption calculation</param>
        /// <param name="Per100Kilometres"/>  Use to calculate the fuel consumption</param>
        /// <param name="ToSeeMilePerGalOption"/> Determine the user's option if they want to see the equivalent result in miles per gallon (mpg)</param>
        /// return value: No return Value
        static void FuelConsumptionOptionMetric() {

            double Litre = 0.0, Kilometre = 0.0, ComsumptionPer100Km = 0.0, EquivalentResultInMPG = 0.0;
            string ToSeeMPerGalOption;
            const double MilePerKilometres = 1.609, GallonPerLitres = 4.546;
            const int Per100Kilometres = 100;

            Console.Write("\nPlease Enter Litres(l) of Fuel used over distance travelled:");
            Litre = double.Parse(Console.ReadLine());
            Console.Write("\nPlease Enter Kilometres driven:");
            Kilometre = double.Parse(Console.ReadLine());
            ComsumptionPer100Km = Litre / (Kilometre / Per100Kilometres);
            Console.WriteLine("\nYour Consumption in Litres per 100 Kilometres is {0}", ComsumptionPer100Km);
            Console.Write("\nWould you like to see the equivalent result in miles per gallon (mpg)?"
                          + "\n(Press Y For yes or Press other key to cancel this option):");
            ToSeeMPerGalOption = Console.ReadLine();
            EquivalentResultInMPG = ((Kilometre / MilePerKilometres) / (Litre / GallonPerLitres));
            if (ToSeeMPerGalOption == "Y" || ToSeeMPerGalOption == "y") {
                Console.Write("\nThe equivalent result in miles per gallon (mpg) is {0}", EquivalentResultInMPG);
            }// End if 

        }// End FuelConsumptionOptionMetric

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Perform Fuel Consumption Calculator In British Imperia measurement,read the Litres used and Kilometres driven in British Imperia, enter by user then perform WaistToHeight Calculation
        /// Pre:  FuelConsumptionMenuOption == 2
        /// Post: Performed  Fuel Consumption Calculator In British Imperia measurement 
        /// return value: No return Value
        /// </summary>
        /// <param name="Gallon"/> Get the Gallons (gal) of Fuel used over distance travelled for fuel consumption Calculation</param>
        /// <param name="Mile"/> Get the  Miles(m) driven for fuel consumption Calculation</param>
        /// <param name="EquivalentResultLitres_Per_100Kilometres"/> For litres per 100 kilometres (1/100km) Calculation</param>
        /// <param name="MilePerKilometres"/>  Mile per Kilometres is 1.609, used for fuel consumption calculation</param>
        /// <param name="ComsumptionPerGal"/>  Calculation for miles per gallon</param>
        /// <param name="GallonPerLitres"/> Gallon per litres is 4.546, used for fuel consumption calculation</param>
        /// <param name="Per100Kilometres"/>  Use to calculate the fuel consumption</param>
        /// <param name="ToSeeLitres_Per_Kilometres_Option"/> Determine the user's option if they want to see the equivalent result in litres per 100 kilometres (1/100km)</param>
        static void FuelConsumptionOptionBritishImperia() {
            double Gallon = 0.0, Mile = 0.0, EquivalentResultLitres_Per_100Kilometres = 0.0, ComsumptionPerGal = 0.0;
            const double MilePerKilometres = 1.609, GallonPerLitres = 4.546;
            const int Per100Kilometres = 100;
            string ToSeeLitres_Per_Kilometres_Option;

            Console.Write("\nPlease Enter Gallons (gal) of Fuel used over distance travelled:");
            Gallon = double.Parse(Console.ReadLine());
            Console.Write("\nPlease Enter Miles (m)driven:");
            Mile = double.Parse(Console.ReadLine());
            ComsumptionPerGal = Mile / Gallon;
            Console.WriteLine("\nYour Consumption in Miles per Gallon is {0}", ComsumptionPerGal);
            Console.Write("\nWould you like to see the equivalent result in litres per 100 kilometres(km)?"
                             + "\n(Press Y For yes or Press other key to cancel this option):");
            ToSeeLitres_Per_Kilometres_Option = Console.ReadLine();

            EquivalentResultLitres_Per_100Kilometres = ((Gallon * GallonPerLitres) / (Mile * MilePerKilometres)) * Per100Kilometres;

            if (ToSeeLitres_Per_Kilometres_Option == "Y" || ToSeeLitres_Per_Kilometres_Option == "y") {
                Console.Write("\nThe equivalent result in litres per 100 kilometres(km) is {0}", EquivalentResultLitres_Per_100Kilometres);
            } //End if

        } //End FuelConsumptionOptionBritishImperia

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Read and perform user's input option and also allow user to enter the valid input for Fuel ConsumptionOption Calculator
        /// Pre: true or BMICalculatorOption is eithr 1, 2 or 3
        /// Post: Read the user's input option and performed option either 1, 2 or 3 
        /// </summary>
        /// <paramref name="FuelConsumptionOptionn"/> Read the input for user's option</param> 
        /// <paramref name="ValidFuelConsumptionOptio"/> Determine the validation of input for user's option</param>
        static int ValidFuelConsumptionMenuReadOption() {

            int FuelConsumptionOption = 0;
            bool ValidFuelConsumptionOption = false;

            do {
                FuelConsumptionOption = int.Parse(Console.ReadLine());

                if ((FuelConsumptionOption >= 1) && (FuelConsumptionOption <= 3)) {
                    ValidFuelConsumptionOption = true;
                } else {
                    ValidFuelConsumptionOption = false;
                } //End if

                if (!ValidFuelConsumptionOption) {
                    Console.WriteLine("\n\t Option must be 1, 2 or 3");
                    FuelConsumptionMenu();
                } //End if 

                if (FuelConsumptionOption == 1) {
                    FuelConsumptionOptionMetric();
                    Console.Write("\nWould you like to make an another Fuel Consumption conversion conversion? \n\n(Enter [Y] to make an another conversion/Enter [N] return to Main menu):");
                } else if (FuelConsumptionOption == 2) {
                    FuelConsumptionOptionBritishImperia();
                    Console.Write("\nWould you like to make an another Fuel Consumption conversion? \n\n(Enter [Y] to make an another conversion/Enter [N] return to Main menu):");
                } else if (FuelConsumptionOption == 3) {
                    Console.Write("\nYour Current Option has been Cancelled"); //Selection cancelled message
                    Main();
                } // End if 

            } while (!ValidFuelConsumptionOption);

            return FuelConsumptionOption;

        } //End ValidFuelConsumptionMenuReadOption

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Allow user to enter valid input for Main menu
        /// Pre: true
        /// Post: return option whose value is either 1, 2 , 3 , 4 or 5
        /// </summary>
        /// <paramref name="MainMenuOption"/> Read the input for user's option</param> 
        /// <paramref name="ValidMainMenuOption"/> Determine the validation of input for user's option</param>
        static int MainMenuReadOption() {
            int MainMenuOption = 0;
            bool ValidMainMenuOption = false;

            do {
                MainMenuOption = int.Parse(Console.ReadLine());

                if ((MainMenuOption >= 1) && (MainMenuOption <= 5)) {
                    ValidMainMenuOption = true;
                } else {
                    ValidMainMenuOption = false;
                } // end if

                if (MainMenuOption == 1) {
                    LengthCalculator();
                } else if (MainMenuOption == 2) {
                    BMICalculator();
                } else if (MainMenuOption == 3) {
                    WaistToHeightCalculator();
                } else if (MainMenuOption == 4) {
                    FuelConsumptionCalculator();
                } else if (MainMenuOption == 5) {
                    
                } // End if 

                if (!ValidMainMenuOption) {
                    Console.WriteLine("\n\t\a Option must be 1,2,3,4 or 5");
                    DisplayMenu();
                } //end if 
            } while (!ValidMainMenuOption);

            return MainMenuOption;

        } //end MainMenuOption

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Display the Main Menu 
        /// Pre:  Start the program
        /// Post: Main menu Displayed
        /// </summary>
        /// <paramref name="mainMenu"/> Menu for Main menu</param>
        /// return value: no return value
        static void DisplayMenu() {
            string mainMenu = "\n1)Length Calculator"
                            + "\n2)Body Mass Index Calculator"
                            + "\n3)Waist to Height Calculator"
                            + "\n4)Fuel Consumption Calculator"
                            + "\n5)Exit the Calculator"
                            + "\n\nEnter your option(1,2,3,4 or 5 to exit):";
            Console.Write(mainMenu);
        } //end DisplayMenu

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Entry point of a C# console application
        /// Pre:  Start the program
        /// Post: Main menu Displayed
        /// </summary>
        /// <paramref name="Exit"/> Allow user to input "5" to terminate the program</param>
        /// <paramref name="menuOption"/> Read user's input is either 1,2,3,4 or 5 and</param>
        /// return value: no return value
        static void Main() {
            const int Exit = 5;
            int menuOption;

            do {
                DisplayMenu();
                menuOption = MainMenuReadOption();

            } while (menuOption != Exit);

            Console.Write("Thank you for using this Calculator. Press any Key to Exit");//terminating message 

            Console.ReadKey(); //// Keep the console open 

        }//end Main

    }//end class

} //end namespace
