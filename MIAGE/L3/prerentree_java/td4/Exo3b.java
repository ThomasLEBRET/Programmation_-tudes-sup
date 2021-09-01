class Exo3b {
    static int jMois = 1;

    static void displayJMois() {
        System.out.println(jMois);
    }
    static void incementJMois() {
        jMois++;
    }
    static void verifJMois(int[] t) {
        boolean res = false;
        for(int i = 0; i< t.length; i++) {
            if(t[i] == jMois) {
                System.out.println("Oui");
                res = true;
            }
        }
        if(!res) {
            t[0] = jMois;
            System.out.println("Non");
        }
    }
   public static void main(String[] args) {
        displayJMois();
        incementJMois();
        displayJMois();
        int[] t = {2,3,1,5};
        verifJMois(t);
   }
}
