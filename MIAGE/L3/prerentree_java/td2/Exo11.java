class Exo11 {
    public static void main(String[] args) {
        int n ;
        for(int i = 0; i < 10; i++) {
            n = (int)Math.round(10 * Math.random());
            
        if(n%2 == 0)
            System.out.println(n + " est pair.");
        else
            System.out.println(n + " est impair.");
        }
    }
}
