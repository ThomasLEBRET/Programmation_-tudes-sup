<?php

require_once("class/datas/Database.php");

class User extends Database {

    private $user;
    private $mdp;
    private $nomcompte;
    private $prenomcompte;
    private $dateinscrip;
    private $dateferme;
    private $typeprofil;
    private $datedebsejour;
    private $datefinsejour;
    private $datenaiscompte;
    private $adrmailcompte;
    private $notelcompte;


    private function buildObject(array $params) {
        foreach ($params as $key => $value) {
            $method = 'set'.ucfirst(strtolower($key));
            if(method_exists($this, $method)) {
                $this->$method($value);
                $_SESSION[$key] = $value;
            }
        }
        return true;
    }

    public function getUser(){
  		return $this->user;
  	}

  	public function setUser($user){
  		$this->user = $user;
  	}

  	public function getMdp(){
  		return $this->mdp;
  	}

  	public function setMdp($mdp){
  		$this->mdp = $mdp;
  	}

  	public function getNomcompte(){
  		return $this->nomcompte;
  	}

  	public function setNomcompte($nomcompte){
  		$this->nomcompte = $nomcompte;
  	}

  	public function getPrenomcompte(){
  		return $this->prenomcompte;
  	}

  	public function setPrenomcompte($prenomcompte){
  		$this->prenomcompte = $prenomcompte;
  	}

  	public function getDateinscrip(){
  		return $this->dateinscrip;
  	}

  	public function setDateinscrip($dateinscrip){
  		$this->dateinscrip = $dateinscrip;
  	}

  	public function getDateferme(){
  		return $this->dateferme;
  	}

  	public function setDateferme($dateferme){
  		$this->dateferme = $dateferme;
  	}

  	public function getTypeprofil(){
  		return $this->typeprofil;
  	}

  	public function setTypeprofil($typeprofil){
  		$this->typeprofil = $typeprofil;
  	}

  	public function getDatedebsejour(){
  		return $this->datedebsejour;
  	}

  	public function setDatedebsejour($datedebsejour){
  		$this->datedebsejour = $datedebsejour;
  	}

  	public function getDatefinsejour(){
  		return $this->datefinsejour;
  	}

  	public function setDatefinsejour($datefinsejour){
  		$this->datefinsejour = $datefinsejour;
  	}

  	public function getDatenaiscompte(){
  		return $this->datenaiscompte;
  	}

  	public function setDatenaiscompte($datenaiscompte){
  		$this->datenaiscompte = $datenaiscompte;
  	}

  	public function getAdrmailcompte(){
  		return $this->adrmailcompte;
  	}

  	public function setAdrmailcompte($adrmailcompte){
  		$this->adrmailcompte = $adrmailcompte;
  	}

  	public function getNotelcompte(){
  		return $this->notelcompte;
  	}

  	public function setNotelcompte($notelcompte){
  		$this->notelcompte = $notelcompte;
  	}

    /**
     * Créé un objet User grâce à un array de données $post et l'hydrate
     * @param  array $post un tableau de données passées via $_POST
     * @return User       Renvoi un objet de type User hydraté
     */
    public function getLogUser($post) {
        $req = "
        SELECT *
        FROM COMPTE
        WHERE USER = ?
        AND MDP = ?
        ";
        $username = $post->get('username');
        $password = $post->get('password');
        $result = $this->createQuery($req, [$username, $password]);
        $user = $result->fetch();
        $result->closeCursor();
        if($result) {
          $this->buildObject((array)$user);
          return true;
        }
        return false;
    }

}
