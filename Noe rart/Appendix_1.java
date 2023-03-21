//Oppgave i

public static void main(String[] args){
  Rom[] rom;
  Gjest[] gjest;
  Reservasjon[] reservasjon;
  
  Hotell hotell = new Hotell();
  
  hotell.registrer_rom("rom_en", 2, 1);
  hotell.registrer_rom("rom_to", 2, 2);
  hotell.registrer_gjest(22, "Donald Duck");
  hotell.registrer_gjest(3, "Mikke Mus");
}
// oppgave a
class Rom{
  
  private int antall_senger;
  private int romnummer;
  
  public Rom(int antall_senger, int romnummer){
    this.antall_senger = antall_senger;
    this.romnummer = romnummer;
  }
}
//oppgave b
class Gjest{
  
  private int kundenummer;
  private String navn;
  
  public Gjest(int kundenummer, String navn ){
    this.kundenummer = kundenummer;
    this.navn = navn;
  }
}
//oppgave c
class Reservasjon{
  
  private Gjest gjest;
  private Rom rom;
  private int antall_senger;
  private int dato_fra;
  private int dato_til;
  
  Reservasjon(Gjest gjest, Rom rom, int antall_senger, int dato_fra, int dato_til){
    this.antall_senger = antall_senger;
    this.gjest = gjest;
    this.rom = rom;
    // Siden jeg er litt usikker på hvordan lage egendefinerte unntak velger jeg å prøve en if statement som sjekker kriteriene
    // for datoene og som printer ut melding om datoen er ugyldig. 
    if (dato_fra < 1 || dato_fra > 365 ){
      System.err.println("Ugyldig dato.");
    }
    else{ this.dato_fra = dato_fra; }
    
    if (dato_til < 1 || dato_til > 365){
      System.err.println("Ugyldig dato.");
    }
    else if (dato_til < dato_fra){
      System.err.println("Kan ikke velge hjemreise tidligere enn ankomst.");
    }
    else{ this.dato_til = dato_til; }
  }
}
//oppgave d
class Hotell{
  
  private Rom rom;
  private int gjester = 0;
  private int reservasjoner = 0;
  public int count = 0;
  
  public Hotell(Rom rom, Gjest gjester, Reservasjon reservasjoner){
    
    this.rom = rom;
    this.gjester = gjester;
    this.reservasjoner = reservasjoner;
  }
  //oppgave e
  public void registrer_rom(String navn, int antall_senger, int romnummer){
    
    Rom navn = new Rom(antall_senger, romnummer);
    
  }
  //oppgave f
  public Gjest registrer_gjest(int kundenummer, String navn){
    Gjest navn = new Gjest(kundenummer, navn);
  }
  
}