using System;
using UnityEngine;

public class PrismCore : MonoBehaviour
{
    // TODO: See if you can make this into a seed thing with the GUID ID
    public readonly Guid Id = Guid.NewGuid();

    // This is needed for inspector
    public PrismGender Gender;
    public PrismRace Race;
    public PrismName Name { get; private set; }
    public PrismBody Body { get; private set; }
    public PrismStats Stats { get; private set; }

    public BattleRank Rank;
    public BattleClassID BattleClassType;
    public BattleClass BattleClass;

    public void Start()
    {
        this.Name ??= new PrismName(Gender, Race);
        this.transform.name = this.Name.FullName;

        this.Body = new PrismBody(Race);
        this.BattleClass = new BattleClass(
            BattleClassType,
            Rank,
            Body
        );
        this.Stats = new PrismStats();

        if (this.Gender == PrismGender.Unknown)
        {
            // TODO: Change this when Female Terrian sprite is ready
            this.Gender = PrismGender.Male;//PrismGenderFactory.RandomGender();
        }
    }

    public void Update()
    {
        
    }
}