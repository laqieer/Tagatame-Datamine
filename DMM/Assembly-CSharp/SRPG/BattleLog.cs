// Decompiled with JetBrains decompiler
// Type: SRPG.BattleLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Text;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BCE")]
  public abstract class BattleLog
  {
    [Token(Token = "0x6002F8A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public virtual void Serialize(StringBuilder dst)
    {
    }

    [Token(Token = "0x6002F8B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public virtual void Deserialize(string log)
    {
    }

    [Token(Token = "0x6002F8C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    protected BattleLog()
    {
    }
  }
}
