package com.example.sio2018.gestionrdv;

import java.time.LocalDate;
import java.util.Date;

public class Consultation {
    private int id;
    private int idMedecin;
    private String date;
    private int heure;
    private String nom;
    private String prenom;


    public Consultation(int pid, int pidMedecin,  String pdate, int pheure, String pnom, String pprenom){
        this.id = pid;
        this.idMedecin = pidMedecin;
        this.date = pdate;
        this.heure = pheure;
        this.nom = pnom;
        this.prenom = pprenom;
    }

    public int getId(){
        return id;
    }

    public int getIdMedecin(){
        return idMedecin;
    }

    public String getDate(){
        return date;
    }

    public int getHeure(){
        return heure;
    }

    public String getNom(){
        return nom;
    }

    public String getPrenom(){
        return prenom;
    }
}
