class Exo4a {
    static int[] convertIntTab(String[] t) {
        int[] tab = new int[t.length];
        for(int i = 0; i < t.length; i++) {
            tab[i] = Integer.parseInt(t[i]);
        }
        return tab;
    }

    static void afficheTab(int[] t) {
        for(int i = 0; i < t.length; i++) {
            System.out.print(t[i] + " ");
        }
        System.out.println();
    }

    static int minTab(int[] t) {
        int min = t[0];
        for(int i = 0; i < t.length; i++) {
            if(t[i] < min)
                min = t[i];
        }
        return min;
    }

    static int[] copyTab(int[] t) {
        int[] tCopy = new int[t.length];
        for(int i = 0; i < t.length; i++)
            tCopy[i] = t[i];
        
        return tCopy;
    }
    public static void main(String[] args) {
        int[] t = convertIntTab(args);
        afficheTab(t);
        System.out.println("Le minimum de ce tableau est : " + minTab(t));
        System.out.println(t);
        System.out.println(copyTab(t));
    }
}