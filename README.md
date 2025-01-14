# RGIS .NET Core WebApp

## Pregled

Ta repozitorij vsebuje .NET Core Web aplikacijo, ki je bila razvita kot del projekta, ki vključuje funkcionalno testiranje, Dockerizacijo in implementacijo na DockerHubu. Aplikacija je zasnovana za obvladovanje in shranjevanje storitev, povezanih z reciklažnimi elektronskimi napravami, ustvarjanjem prevzemov in registracijo uporabnikov, s poudarkom na jasnem uporabniškem vmesniku in interakciji sistema.

## Funkcionalnosti

- Registracija in prijava uporabnikov
- Upravljanje z elektronskimi napravami za reciklažo in prodajo
- Natančno iskanje in filtriranje lokacij za uporabnike
- Prikaz reciklažnih lokacij in filtriranje lokacij po iskalnih kriterijih
- Administrativne funkcionalnosti za upravljanje uporabnikov, lokacij in oglasov

## Kako zagnati aplikacijo

### Predpogoji

Prepričajte se, da imate na svojem računalniku nameščen Docker. Prav tako boste potrebovali GitHub račun, da dostopate do repozitorija in potrebnih datotek.

### Zagon preko Dockerja

1. Klonirajte repozitorij na lokalni računalnik:
    ```bash
    git clone https://github.com/FranPetkovic/VisualParadigmDotNetCoreApp.git
    ```

2. Pojdite v mapo s projektom:
    ```bash
    cd VisualParadigmDotNetCoreApp
    ```

3. Zgradite in zaženite aplikacijo v Dockerju:
    ```bash
    docker build -t franpetkovic/franrgis .
    docker run -p 8080:80 franpetkovic/franrgis
    ```

4. Odprite spletni brskalnik in obiščite [http://localhost:8080](http://localhost:8080), da dostopate do aplikacije.

### Zagon preko Visual Studio

1. Odprite projekt v Visual Studio.
2. Pritisnite F5, da zgradite in zaženete aplikacijo v načinu za odpravljanje napak.

## Testni scenariji

Za projekt so bili pripravljeni naslednji testni scenariji:

1. **Prijava z veljavnimi podatki**
    - **Opis**: Odprite aplikacijo preko Dockerja in pojdite na stran za prijavo. Vnesite veljavne uporabniške podatke:
      - uporabniško ime: jnovak
      - geslo: password123
    - **Pričakovani rezultat**: Uporabnik se uspešno prijavi in preusmeri na domačo stran ali nadzorno ploščo.

2. **Poskus prijave z napačnimi podatki**
    - **Opis**: Odprite aplikacijo preko Dockerja in pojdite na stran za prijavo. Vnesite napačne uporabniške podatke:
      - uporabniško ime: jnovak
      - napačno geslo: wrongpassword
    - **Pričakovani rezultat**: Uporabnik vidi napako "Neveljavna uporabniška imena ali geslo."

3. **Registracija novega uporabnika**
    - **Opis**: Odprite aplikacijo preko Dockerja in pojdite na stran za registracijo. Vnesite veljavne registracijske podatke:
      - uporabniško ime: testuser
      - e-pošta: testuser@example.com
      - geslo: password123
    - **Pričakovani rezultat**: Nov uporabnik se uspešno registrira in preusmeri na stran za prijavo.

4. **Filtriranje lokacij na podlagi iskalnega kriterija**
    - **Opis**: Odprite aplikacijo preko Dockerja in pojdite na stran z reciklažnimi lokacijami. Vnesite iskalni kriterij (npr. Ljubljana) in kliknite "Išči".
    - **Pričakovani rezultat**: Seznam lokacij se filtrira, prikazani so samo tisti, ki ustrezajo iskalnemu kriteriju.

## Funkcionalno testiranje

**Testni scenariji:**

Vsi testni primeri so bili izvedeni ročno z uporabo zgoraj opisanih testnih scenarijev. Testi so bili izvedeni na Dockerizirani različici aplikacije, ki simulira dejanske uporabniške scenarije. Rezultati testov so bili dokumentirani v GitHub Issues. Če je kateri koli test spodletel, je bila ustrezna težava označena z oznako bug. Težave so bile zaprte, ko so bili testi uspešno zaključeni.

**Rezultati testiranja:**

Vsi testi so bili uspešno izvedeni. V primeru, da so bile odkrite napake ali težave, so bile zapisane kot bug v GitHub repozitoriju in odpravljene.

## Težave in sledenje napakam

Vse težave in napake so bile dokumentirane v GitHub Issues:
- Testni scenariji so bili označeni z oznako `question`.
- Napake so bile označene z `bug` in odpravljene v kodi.

## Namestitev

Aplikacija je bila uspešno Dockerizirana in je na voljo na Docker Hub. Za namestitev sledite korakom, omenjenim v razdelku **Kako zagnati aplikacijo**.

