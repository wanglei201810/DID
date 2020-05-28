using System;
using AElf.Sdk.CSharp;
using AElf.Types;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;

namespace AElf.Contracts.DigitalIDContract
{
    public class DigitalIDContract : DigitalIDContractContainer.DigitalIDContractBase
    {
        // submit information
        public override Empty AddInfo(StringValue info)
        {
            Address adr = Context.Sender;
            Hash ha = Hash.Empty;
            ha.Value = adr.Value;
            var stuff = State.Stuffs[ha];
            if (!stuff.Info.Contains(info.Value))
            {
                stuff.Info.Add(info.Value);
            }

            State.Stuffs[ha] = stuff;
            return new Empty();
        }
        
        // submit call
        public override Empty AddCall(StringValue call)
        {
            Address adr = Context.Sender;
            Hash ha = Hash.Empty;
            ha.Value = adr.Value;
            var stuff = State.Stuffs[ha];
            if (!stuff.Call.Contains(call.Value))
            {
                stuff.Call.Add(call.Value);
            }
        
            State.Stuffs[ha] = stuff;
            return new Empty();
        }
        
        //submit user
        public override Empty AddUser(StringValue adrs)
        {
            Address adr = Context.Sender;
            Hash ha = Hash.Empty;
            ha.Value = adr.Value;
            var stuff = State.Stuffs[ha];
            if (!stuff.Adresses.Contains(adrs.Value))
            {
                stuff.Adresses.Add(adrs.Value);
            }
            State.Stuffs[ha]= stuff;
            return new Empty();
        }
        
        //delete user
        public override Empty DelUser(StringValue user)
        {
            Address adr = Context.Sender;
            Hash ha = Hash.Empty;
            ha.Value = adr.Value;
            var stuff = State.Stuffs[ha];
            stuff.Adresses.Remove(user.Value);
            State.Stuffs[ha] = stuff;
            return new Empty();
        }
        
        //get stuff
        public override Stuff GetStuff(Hash input)
        {
            Address adr = Context.Sender;
            Hash ha = Hash.Empty;
            ha.Value = adr.Value;
            return State.Stuffs[ha] ?? new Stuff();
        }
    }
}