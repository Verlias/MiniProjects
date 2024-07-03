public class SOCAlgo {
    //Function 1: Finds the 3-Digit Numbers equal to its SOC
    public static void CalculateValues(){
        for (int StarterValue = 100; StarterValue<=999; StarterValue++){
            int OnesDigit = StarterValue % 10;
            int TensDigit = ((StarterValue / 10) % 10);
            int HundredsDigit = StarterValue / 100;
            int Sum = cube(OnesDigit) + cube(TensDigit) + cube(HundredsDigit);

            if (Sum == StarterValue){
                System.out.println();
                System.out.print(Sum);
            }

        }

    }

    //Function 2:Cube Numbers
    public static int cube(int number){
        return number * number * number;

    }

    public static void main(String[] args){
        CalculateValues();
    }

}
