class Exo13 {
    public static void main(String[] args) {
        int p;
        double alea;
        int total = 0;
        do {
            p = Integer.parseInt(args[0]);
        } while (p > 99 || p < 0);

        while(total < p) {
            alea = Math.round(Math.random() * 6);
            switch((int)alea) {
                case 1 : 
                    total++;
                    break;
                case 2:
                    total += 2;
                    break;
                case 3 : 
                    total += 5;
                    break;
                case 4 : 
                    total += 10;
                    break;
                case 5 : 
                    total += 20;
                    break;
                case 6 : 
                    total += 50;
                    break;
            }
        }
        System.out.println(total);
    }
}
