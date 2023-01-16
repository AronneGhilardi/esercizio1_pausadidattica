# esercizio1_pausadidattica

Un telefono è caratterizzato da un identificatore, il modello è un produttore.
Ad ogni telefono ha inoltre un certo credito in euro, che viene utilizzato per effettuare le chiamate.
Ogni telefono consente le seguenti operazioni:
Ricaricare: aumenta il credito telefonico di una certa cifra.
Avviar: avvia una sessione di comunicazione telefonica.
Digitare: invia un carattere telefonico (numeri 0-9, simboli + # *). Il carattere inviato viene aggiunto ai caratteri della sessione.
Comporre: effettua un tentativo di chiamata verso il numero inserito mediante digitazioni precedenti. 
L'operazione restituisce true o false a seconda che la chiamata sia stata possibile.
Una chiamata è possibile se il numero di telefono digitato è di una delle forme seguenti: 
- <PREFISSOLOCALE><NUMERO>, ove prefisso locale è una sequenza di 3 o 4 caratteri numerici, numero una sequenza 7 o 8 o 9 caratteri numerici,
- <PREFISSOINT><PREFISSOLOCALE><NUMERO>, ove prefisso internazionale è sequenza firmata dal simbolo + seguito da due caratteri numerici.
Per ogni chiamata viene addebitato il relativo costo sul credito: le chiamate locali costano 1 euro, quelle internazionali 10 euro. 
Il credito può essere negativo ma arrivare al massimo a -10 euro. Oltre questa soglia nessuna chiamata è possibile.
AggiungereNero: dato un numero telefonico lo aggiunge alla lista di numeri che non possono essere chiamati ('blacklist').
EliminareNero: elimina un numero telefonico dalla blacklist.
visualizzareNero: visualizza tutti i numeri della blacklist.
