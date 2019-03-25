package com.example.sio2018.gestionrdv;

import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        TacheAsync maTache = new TacheAsync();
        maTache.execute();
    }
    public class TacheAsync extends AsyncTask<String, Integer, String> {
        @Override
        protected void onPostExecute(String pResult){
            super.onPostExecute(pResult);
            TextView txtVw = (TextView) findViewById(R.id.lblAff);
            String lesConsultation = "";
            try{
                JSONArray lesConsult = new JSONArray(pResult);
                JSONObject consult;
                for (int i=0; i<lesConsult.length(); i++)
                {
                    consult = lesConsult.getJSONObject(i);
                    lesConsultation += consult.getString("id")+" "+consult.getString("mdp");
                    //lesConsultation += consult.getString("nomPatient")+consult.getString("prenomPatient")+consult.getString("date")+consult.getString("heure")+consult.getString("nomMedecin")+" "+consult.getString("prenomMedecin")+"\n";
                }
            }
            catch(Exception e){
                pResult+="\n erreur de recup objet\n"+e.getMessage();
            }
            //lesConsultation = pResult;
            txtVw.setText(lesConsultation);
        }

        @Override
        protected void onProgressUpdate (Integer... pAvancement){
            super.onProgressUpdate(pAvancement);
            String affichage = "nasa";
            switch (pAvancement[0]){
                case 1:
                    affichage = "initialisation";
                    break;
                case 2:
                    affichage = "appel service web";
                    break;
                default :
                    break;
            }

        }

        @Override
        protected String doInBackground(String... arg0){
            String aRetourner="";
            URL url;
            StringBuffer leBuffer = new StringBuffer(aRetourner);
            try{
                url = new URL("http://192.168.1.17/script.php");
                HttpURLConnection conn = (HttpURLConnection) url.openConnection();
                conn.setRequestMethod("GET");

                conn.setDoInput(true);
                conn.setDoOutput(true);

                InputStream leFluxEntree = new BufferedInputStream(conn.getInputStream());
                BufferedReader leLecteur = new BufferedReader(new InputStreamReader(leFluxEntree));
                String laLigne = leLecteur.readLine();
                while (laLigne != null){
                    leBuffer.append(laLigne);
                    leBuffer.append("\n");
                    laLigne = leLecteur.readLine();
                }
                aRetourner = leBuffer.toString();
            }catch (Exception e){
                e.printStackTrace();
                aRetourner = e.getMessage();
            }
            //aRetourner = "[{'nomPatient':'Tes','prenomPatient':'Tes','date':'2019-03-15','heure':'12','nomMedecin':'jablonski','prenomMedecin':'tom'}]";
            return aRetourner;
        }

    }
}
