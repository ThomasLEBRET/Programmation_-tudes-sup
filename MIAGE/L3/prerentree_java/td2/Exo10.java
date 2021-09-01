class Exo10 {
    public static void main(String[] args) {
        int n = (int)Math.round(10 * Math.random());
        if(n%2 == 0)
            System.out.println(n + " est pair.");
        else
            System.out.println(n + " est impair.");
    }
}
