using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {cell_0, cell_1, cell_2, bowl, crust, eat, gaoler_0,
                        help, curse, ask, help_fight_0, help_fight_1, protection,
                        ceinar_0, ceinar_1, ceinar_2, ceinar_3, ceinar_4,
                        fields_0, woods_0, tor_0, ghostfence, spiritguardian_0, spiritguardian_1,
                        lamb};
    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.cell_0;
	}
	
	// Update is called once per frame
	void Update () {
        if (myState == States.cell_0)           { cell_0(); }
        else if (myState == States.cell_1)      { cell_1(); }
        else if (myState == States.cell_2)      { cell_2(); }
        else if (myState == States.bowl)        { bowl(); }
        else if (myState == States.crust)       { crust(); }
        else if (myState == States.eat)         { eat(); }
        else if (myState == States.gaoler_0)    { gaoler_0(); }
        else if (myState == States.help)        { help(); }
        else if (myState == States.curse)       { curse(); }
        else if (myState == States.ask)         { ask(); }
        else if (myState == States.help_fight_0)    { help_fight_0(); }
        else if (myState == States.help_fight_1)    { help_fight_1(); }
        else if (myState == States.protection)  { protection(); }
        else if (myState == States.ceinar_0)    { ceinar_0(); }
        else if (myState == States.ceinar_1)    { ceinar_1(); }
        else if (myState == States.ceinar_2)    { ceinar_2(); }
        else if (myState == States.ceinar_3)    { ceinar_3(); }
        else if (myState == States.ceinar_4)    { ceinar_4(); }
        else if (myState == States.woods_0)     { woods_0(); }
        else if (myState == States.fields_0)    { fields_0(); }
        else if (myState == States.tor_0)       { tor_0(); }
        else if (myState == States.ghostfence)      { ghostfence(); }
        else if (myState == States.spiritguardian_0)  { spiritguardian_0(); }
        else if (myState == States.spiritguardian_1)  { spiritguardian_1(); }
        else if (myState == States.lamb)            { lamb(); }

    }

    void cell_0()
    {
        text.text = "It is a dark time. Britons are warring against each other, " +
            "The saxon continues to gain strength, taking more land and slaves each month. " +
            "Belief in the Old Gods of Britain is waning and the druids are all but gone.\n" +
            "You are one of the last of them.  " +
            "And you have been captured by the Saxons.\n\n" +
            "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space))    { myState = States.cell_1; }
    }

    void cell_1 ()
    {
        text.text = "Your eyes open suddenly to the sound of a slamming door. " +
            "Although still dark, you discern a glimmer of light through " +
            "the bars of your cell.\n\n" +
            "It appears that your Gaoler is approaching. " +
            "A hatch opens and something is pushed through.\n\n" +
            "Press Space to continue.";

        if (Input.GetKeyDown(KeyCode.Space))    { myState = States.cell_2; }
    }

    void cell_2()
    {
        text.text = "It's a wooden bowl containing a crust of bread, soaked in " +
            "water.\n\n " +
            "Do you.: \n" +
            "   Examine the (B)owl, Examine the (C)rust,\n " +
            "   (E)at the food, or (H)ail the Gaoler\n";

        if (Input.GetKeyDown(KeyCode.B))        { myState = States.bowl; }
        else if (Input.GetKeyDown(KeyCode.C))   { myState = States.crust; }
        else if (Input.GetKeyDown(KeyCode.E))   { myState = States.eat; }
        else if (Input.GetKeyDown(KeyCode.H))   { myState = States.gaoler_0; }

    }

    void bowl()
    {
        text.text = "It is an ordinary, roughly carved wooden bowl.\n\n " +
            "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space))    { myState = States.cell_2; }
    }

    void crust()
    {
        text.text = "The bread is stale and dark with a hint of mold.\n\n " +
            "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.cell_2; }
    }

    void eat()
    {
        text.text = "It's not much worse than you're used to. You feel a little " +
            "better and doze off to sleep.\n\n" +
            "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.cell_1; }
    }

    void gaoler_0()
    {
        text.text = "'Wait!  Wait.' you shout. You hear the footsteps stop and a " +
            "hesitant voice replies 'W..what is it?' \n" +
            "He is a Briton! Perhaps a slave of the Saxons. He sounds fearful. " +
            "Do you.: \n" +
            "   Ask him for (H)elp, Threaten to (C)urse him, \n " +
            "   or (A)sk how he came to be here. \n";
        
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.help; }
        else if (Input.GetKeyDown(KeyCode.C)) { myState = States.curse; }
        else if (Input.GetKeyDown(KeyCode.A)) { myState = States.ask; }
        
    }

    void help()
    {
        text.text = "The Gaoler is too afraid of the Saxons to help you.\n " +
            "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gaoler_0; }
    }

    void curse()
    {
        text.text = "You threaaten to burn the tongue of a goat to curse him with hunger, " +
           "but it seems he is more afraid of the Saxons than your curse.\n\n" +
           "Press Space to continue";
        
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gaoler_0; }
    }

    void ask()
    {
        text.text = "He says his name is Hygwdd, and this is, or rather was his village before " +
            "the Saxons took it. Now everyone must work the fields to feed them - and the villagers are " +
            "kept in line by just a handful of spearmen and two Saxon wizards. It's the wizards " +
            "they are afraid of - they threaten their families\n\n" +
            "Do you " +
            "Offer to (H)help the villagers fight the Saxons, or " +
            "Offer to place charms of (P)rotection for his family if he sneaks you out" ;

        if (Input.GetKeyDown(KeyCode.H)) { myState = States.help_fight_0; }
        else if (Input.GetKeyDown(KeyCode.P)) { myState = States.protection; }
    }

    void protection()
    {
        text.text = "You offer to bury two pig-skulls, facing North to counter any " +
           "spells directed at his family, but he thinks it won't be soon enough.\n\n" +
           "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.ask; }
    }

    void help_fight_0()
    {
        text.text = "The next day, Hygwdd brings your food, and opens the door. " +
           "You step out into the sun and see a small group of saxon spearmen sitting drinking " +
           "in the centre of the village. With them, their hair stiffened into spikes with " +
           "pigfat are the two wizards. They stand and shout at seeing you, and the spearmen jump to their feet.\n\n" +
           "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.help_fight_1; }
    }

    void help_fight_1()
    {
        text.text = "With a roar, a dozen Britons rush into the square, armed with axes, pitchforks and slings. " +
           "The spearmen lined up, facing the Britons - and their wizards came forward, bouncing on all fours, " +
           "barking and howling curses at the Britons - who start backing off in fear. At this, you stride forward, " +
           "one eye covered, one hand in the air, hopping on one leg, and start spitting to avert their evil spells.\n" +
           "The villagers, emboldened, rush to attack. The Wizards turn and run, and the saxon spearmen, seeing their " +
           "wizards flee from the might of a British Druid, turn and run after them.\n\n" +
           "Press Space to continue";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.ceinar_0; }
    }
    void ceinar_0()
    {
        text.text = "You have escaped - and village is safe - for now!\n\n" +
           "Hygwdd explains that the village is called Ceinar, and that it came " +
           "under Saxon occupation several years ago. Most of them left, but only after " +
           "those wizards were seen to curse the lands with blight, and our families with " +
           "pestilence should we revolt. He spat to avert evil. " +
           "They didn't need many spearmen to keep us cowed.\n\n" +
           "Press Space to continue";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.ceinar_1; }
    }

    void ceinar_1()
    {
        text.text = "'Can you help us please?', Hygwdd worriedly asks.\n\n" +
           "- It seems you must find a way to remove the curse. Dot you:\n" +
           "- Investigate the (V)illage of Ceinar.\n" +
           "- Investigate the (F)ields.\n" +
           "- Investigate the nearby (W)oods.\n" +
           "- Investigate the nearby hill with a stone (T)or at its summit.";
        if (Input.GetKeyDown(KeyCode.V))        { myState = States.ceinar_2; }
        else if (Input.GetKeyDown(KeyCode.F))   { myState = States.fields_0; }
        else if (Input.GetKeyDown(KeyCode.W))   { myState = States.woods_0; }
        else if (Input.GetKeyDown(KeyCode.T))   { myState = States.tor_0; }
    }

    void ceinar_2()
    {
        text.text = "The Villagers have already tried to protect themselves " +
           "from the Saxon curses by hanging mugwort at their windows, " +
           "but they don't believe it will be enough. A strong counterspell " +
           "will be needed to reassure them.\n\n" +
           "Press space to continue";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.ceinar_1; }
    }

    void fields_0()
    {
        text.text = "You ask Hygwdd if the villagers sacrificed a lamb and " +
           "buried it near the fields to give a good harvest. He says that they " +
           "always do, and takes you to the place. You ask him to dig it up - and " +
           "see that it is rotten and badly decomposed.\n" +
           "You tell him that it is drawing the evil to itself and has protected the " +
           "fields so far. But more is needed. You re-bury it and head back to the village.\n\n" +
           "Press space to continue";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.ceinar_1; }
    }

    void woods_0()
    {
        text.text = "You head to the woods and hear the howling of wolves.\n " +
           "It wouldn't be wise to go inside.\n\n " +
           "Press space to continue";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.ceinar_1; }
    }

    void tor_0()
    {
        text.text = "It's a long, steep climb up the hill to the Tor, but on " +
           "arrival you immediately see the possibilities. This is a Druid place. " +
           "A place of the Old Gods. A place of power!\n" +
           "You now know what you need - and head back to the village.\n\n" +
           "Press space to continue";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.ceinar_3; }
    }


    void ceinar_3()
    {
        text.text = "You find a crowd assembled as the villagers await your return " +
           "with hope in their eyes.\n " +
           "'My name is Leyn,' you cry, 'And I will rid you of this curse - " +
           "but will need your help'.\n\n" +
           "Press space to continue";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.ceinar_4; }
    }


    void ceinar_4()
    {
        text.text = "Do you ask them to:\n\n" +
           "- Find 6 bovine skulls so you can erect a (G)host-fence around the village.\n" +
           "- Hunt of a wolf and sacrifice a dog so you can summon a (S)pirit guardian.\n" +
           "- Fetch you a (L)amb to sacrifice so you can protect the fields.";
        if      (Input.GetKeyDown(KeyCode.G)) { myState = States.ghostfence; }
        else if (Input.GetKeyDown(KeyCode.S)) { myState = States.spiritguardian_0; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.lamb; }
    }

    void ghostfence()
    {
        text.text = "The villages soon come back with several cow-skills from their " +
           "refuse pits. You carefully mount them on poles driven into the ground to make " +
           "corners of a ghostly fence around the village. Everyone knows that a ghostfence " +
           "can keep evil magic out.\n" +
           "But the villagers were not convinced. They did not believe the old lamb would be " +
           "enough to protect their fields, so they stayed by them worried about the impending blight.\n" +
           "Eventually the Saxons returned - in numbers. Their wizards dispelled the ghost-fence, and " +
           "the villagers were all slaughtered\n\n" +
           "GAME OVER!";
    }


    void spiritguardian_0()
    {
        text.text = "The village hunters head to the woods and soon come back with a dead wolf, " +
           "while one of them brings an old family dog. You order them brought to the summit of " +
           "the Tor. You clear a space, and erect a small ghost-fence around a large, flat stone - " +
           "leaving the side pointing towards the village open.\n" +
           "You then order the wolf to be skinned, and sacrifice the old, loyal dog over the flat stone, " +
           "then lay the wolf's skin over the dog and bury it under the stone, facing the village.\n\n" +
           "Press space to continue.";
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.spiritguardian_1; }
    }
    
    void spiritguardian_1()
    {
        text.text = "'This loyal dog', you explain, 'has been given the strength of the Wolf!'. " +
           "'The Ghost-Fence keeps it looking over the village and the fields, " +
           "it will protect you from any evil curses for as long as you hold this Tor sacred.'\n " +
           "The villagers are awed, and grateful. They feel emboldened by your presence, and spread out " +
           "to carry word of your deeds, recruiting other warriors from other captured villages to build " +
           "a force strong enough to fight the saxons.\n " +
           "They are so greatful that they ask you to stay and grant you the Tor, making you its Mayor.\n" +
           "It became a symbol of British resistance. Ceinar-Tor and Mayor Leyn! ";
    }


    void lamb()
    {
        text.text = "You ask the villagers to fetch you a new lamb to dedicate to " +
           "Beli Mawr to protect the fields.\n" +
           "They curse you for a fool as the lambing season is long over - and drive you from the village.\n\n" +
           "GAME OVER!";
    }
}
