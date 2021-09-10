class Exo11 {
    public static void main(String[] args) {
        //M(i,j) == M'(j,i)
        int[][] t = { {1,2,3}, {4,5,6} };
        int[][] tP = { {7,8}, {9,-1}, {-2,-3} };

        if(t.length == tP.length && t[0].length == tP[0].length) {
            int[][] tPr = new int[t.length][t[0].length];
            for(int i = 0; i < t.length; i++) {
                for(int j = 0; j < t[0].length; j++) {
                    tPr[i][j] = t[i][j] + tP[i][j];
                }
            }
            for(int i = 0; i < tPr.length; i++) {
                for(int j = 0; j < tPr[i].length; j++) {
                    System.out.print(tPr[i][j] + " ");
                }
                System.out.println();
            }
        }   
        else {
            System.out.println("Les matrices ne sont pas additionnables !");
        }

        // Multiplication matricielle
        if(t[0].length == tP.length && t.length == tP[0].length) {
            int sizeI = t.length;
            int sizeJ = tP[0].length;

            int[][] tRes = new int[sizeI][sizeJ];

            for(int i = 0; i < sizeI; i++) {
                for(int j =0; j < sizeJ; j++) {
                    for(int k = 0; k < tP.length; k++) {
                        tRes[i][j] += t[i][k] * tP[k][j];
                    }
                }
            }
            
            //Affichage
            for(int i = 0; i < tRes.length; i++) {
                for(int j = 0; j < tRes[i].length; j++) {
                    System.out.print(tRes[i][j] + " ");
                }
                System.out.println();
            }

        }
        else {
            System.out.println("Les matrices ne sont pas multipliables entres elles !");    
        }
    }    
}
