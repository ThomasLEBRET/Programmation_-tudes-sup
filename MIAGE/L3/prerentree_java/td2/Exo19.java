class Exo19 {
    public static void main(String[] args) {
        int n = 0;
        double sn = 2 - (1/Math.pow(2,n));
        double e = 0.005;
        while(sn >= e) {
            sn = 2 - (sn/2);
            n++;
        }
        System.out.println(n);
    }
}
