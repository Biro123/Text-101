using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {cell_0, cell_1, cell_2, bowl, crust, eat, gaoler_0,
                        help, curse, ask, help_fight_0, help_fight_1, protection };
    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.cell_0;
	}
	
	// Update is called once per frame
	void Update () {
        if (myState == States.cell_0)           { state_cell_0(); }
        else if (myState == States.cell_1)      { state_cell_1(); }
        else if (myState == States.cell_2)      { state_cell_2(); }
        else if (myState == States.bowl)        { state_bowl(); }
        else if (myState == States.crust)       { state_crust(); }
        else if (myState == States.eat)         { state_eat(); }
        else if (myState == States.gaoler_0)    { state_gaoler_0(); }
        else if (myState == States.help)        { state_help(); }
        else if (myState == States.curse)       { state_curse(); }
        else if (myState == States.ask)         { state_ask(); }
        else if (myState == States.help_fight_0)    { state_help_fight_0(); }
        else if (myState == States.help_fight_1)    { state_help_fight_1(); }
        else if (myState == States.protection)  { state_protection(); }

    }

    void state_cell_0()
    {
        text.text = "It is a dark time. Britons are warring against each other, " +
            "The saxon continues to gain strength, taking more land and slaves each month. " +
            "Belief in the Old Gods of Britain is waning and the druids are all but gone.\n" +
            "You are one of the last of them.  " +
            "And you have been captured by the Saxons.\n\n" +
            "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space))    { myState = States.cell_1; }
    }

    void state_cell_1 ()
    {
        text.text = "Your eyes open suddenly to the sound of a slamming door. " +
            "Although still dark, you discern a glimmer of light through " +
            "the bars of your cell.\n\n" +
            "It appears that your Gaoler is approaching. " +
            "A hatch opens and something is pushed through.\n\n" +
            "Press Space to continue.";

        if (Input.GetKeyDown(KeyCode.Space))    { myState = States.cell_2; }
    }

    void state_cell_2()
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

    void state_bowl()
    {
        text.text = "It is an ordinary, roughly carved wooden bowl.\n\n " +
            "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space))    { myState = States.cell_2; }
    }

    void state_crust()
    {
        text.text = "The bread is stale and dark with a hint of mold.\n\n " +
            "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.cell_2; }
    }

    void state_eat()
    {
        text.text = "It's not much worse than you're used to. You feel a little " +
            "better and doze off to sleep.\n\n" +
            "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.cell_1; }
    }

    void state_gaoler_0()
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

    void state_help()
    {
        text.text = "The Gaoler is too afraid of the Saxons to help you.\n " +
            "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gaoler_0; }
    }

    void state_curse()
    {
        text.text = "You threaaten to burn the tongue of a goat to curse him with hunger, " +
           "but it seems he is more afraid of the Saxons than your curse.\n\n" +
           "Press Space to continue";
        
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gaoler_0; }
    }

    void state_ask()
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

    void state_protection()
    {
        text.text = "You offer to bury two pig-skulls, facing North to counter any " +
           "spells directed at his family, but he thinks it won't be soon enough.\n\n" +
           "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.ask; }
    }

    void state_help_fight_0()
    {
        text.text = "The next day, Hygwdd brings your food, and opens the door. " +
           "You step out into the sun and see a small group of saxon spearmen sitting drinking " +
           "in the centre of the village. With them, their hair stiffened into spikes with " +
           "pigfat are the two wizards. They stand and shout at seeing you, and the spearmen jump to their feet.\n\n" +
           "Press Space to continue";

        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.help_fight_1; }
    }

    void state_help_fight_1()
    {
        text.text = "With a roar, a dozen Britons rush into the square, armed with axes, pitchforks and slings. " +
           "The spearmen lined up, facing the Britons - and their wizards came forward, bouncing on all fours, " +
           "barking and howling curses at the Britons - who start backing off in fear. At this, you stride forward, " +
           "one eye covered, one hand in the air, hopping on one leg, and start spitting to avert their evil spells.\n" +
           "The villagers, emboldened, rush to attack. The Wizards turn and run, and the saxon spearmen, seeing their " +
           "wizards flee from the might of a British Druid, turn and run after them.\n\n" +
           "You have escaped - and freed a village in the process!";
           

    }
}
