namespace ObliczanieObrazekConsole;

public class WeaponDamage
{
    private int _roll;
    private bool _flaming;
    private bool _magic;
    
    public int Damage {  get; protected set; }

    public int Roll
    {
        get { return _roll; } 
        set { 
            _roll = value;
            CalculateDamage();
        }
    }

    public bool Flaming {  
        get { return _flaming; } 
        set { 
            _flaming = value; 
            CalculateDamage();
        } 
    }
        
    public bool Magic {  
        get { return _magic; } 
        set { 
            _magic = value; 
            CalculateDamage();
        } 
    }

    public WeaponDamage(int roll)
    {
        this.Roll = roll;
        CalculateDamage();
    }

    protected virtual void CalculateDamage() { }
}