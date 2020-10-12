<?php

class Database {

    const DB_HOST = 'mysql:host=localhost;dbname=gatci;charset=utf8';
    const DB_USER = 'root';
    const DB_PASS = '';

    private $pdo;

    private function checkConnexion() {
        if($this->pdo === null) {
            return $this->getConnexion();
        }
        return $this->pdo;
    }

    public function getConnexion() {
        try {
            $pdo = new PDO(self::DB_HOST, self::DB_USER, self::DB_PASS);
            $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            $this->pdo = $pdo;
            return $this->pdo;
        } catch (\Exception $e) {
            die ('Erreur de connection : '.$e->getMessage());
        }
    }

    protected function createQuery($myRequest, $params = null) {
        if($params) {
            $result = $this->checkConnexion()->prepare($myRequest);
            $result->setFetchMode(PDO::FETCH_CLASS, static::class);
            $result->execute($params);
            return $result;
        }
        $result = $this->checkConnexion()->query($myRequest);
        $result->setFetchMode(PDO::FETCH_CLASS, static::class);
        return $result;
    }
}
