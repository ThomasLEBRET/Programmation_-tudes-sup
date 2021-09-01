class Exo18 {
    public static void main(String[] args) {
        int n = 0;
        double sn = 1/Math.pow(2,n);
        double e = 0.005;
        while(sn >= e) {
            sn = sn/2;
            n++;
        }
        System.out.println(n);
    }
}
