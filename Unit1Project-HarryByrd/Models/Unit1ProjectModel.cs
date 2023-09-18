using System.ComponentModel.DataAnnotations;

namespace Unit1Project_HarryByrd.Models
{
    public class Unit1ProjectModel
    {
        [Required(ErrorMessage = "Please enter a number.")]
        public int? NumberInput { get; set; }
        [Required(ErrorMessage = "Please enter a letter.")]
        public string? LetterInput { get; set; }
        public string? GenerateMemeName()
        {
            string? number = "ERROR";
            if (NumberInput == 0)
            {
                number = "Big";
            }
            else if (NumberInput == 1)
            {
                number = "Robbie";
            }
            else if (NumberInput == 2)
            {
                number = "Sonic";
            }
            else if (NumberInput == 3)
            {
                number = "Quandale";
            }
            else if (NumberInput == 4)
            {
                number = "Michael";
            }
            else if (NumberInput == 5)
            {
                number = "King";
            }
            else if (NumberInput == 6)
            {
                number = "I.M.";
            }
            else if (NumberInput == 7)
            {
                number = "Spongebob";
            }
            else if (NumberInput == 8)
            {
                number = "Barry B.";
            }
            else if (NumberInput == 9)
            {
                number = "Ugandan";
            }

            string? letter = "ERROR";
            if (LetterInput.ToLower() == "a")
            {
                letter = "Chungus";
            }
            else if (LetterInput.ToLower() == "b")
            {
                letter = "Rotten";
            }
            else if (LetterInput.ToLower() == "c")
            {
                letter = "the Hedgehog";
            }
            else if (LetterInput.ToLower() == "d")
            {
                letter = "Dingle";
            }
            else if (LetterInput.ToLower() == "e")
            {
                letter = "Rosen";
            }
            else if (LetterInput.ToLower() == "f")
            {
                letter = "Harkinian";
            }
            else if (LetterInput.ToLower() == "g")
            {
                letter = "Meen";
            }
            else if (LetterInput.ToLower() == "h")
            {
                letter = "Squarepants";
            }
            else if (LetterInput.ToLower() == "i")
            {
                letter = "Benson";
            }
            else if (LetterInput.ToLower() == "j")
            {
                letter = "Knuckles";
            }

            string? memeName = number + " " + letter;
            
            return memeName;
        }
    }
}
