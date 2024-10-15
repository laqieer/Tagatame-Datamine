// Decompiled with JetBrains decompiler
// Type: SRPG.EventTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EBE")]
  [MessagePackObject(true)]
  public class EventTrigger
  {
    [Token(Token = "0x4002D75")]
    [FieldOffset(Offset = "0x8")]
    private EEventTrigger mTrigger;
    [Token(Token = "0x4002D76")]
    [FieldOffset(Offset = "0xC")]
    private EEventType mEventType;
    [Token(Token = "0x4002D77")]
    [FieldOffset(Offset = "0x10")]
    private EEventGimmick mGimmickType;
    [Token(Token = "0x4002D78")]
    [FieldOffset(Offset = "0x14")]
    private string mStrValue;
    [Token(Token = "0x4002D79")]
    [FieldOffset(Offset = "0x18")]
    private int mIntValue;
    [Token(Token = "0x4002D7A")]
    [FieldOffset(Offset = "0x1C")]
    private int mCount;
    [Token(Token = "0x4002D7B")]
    [FieldOffset(Offset = "0x20")]
    private string mTag;

    [Token(Token = "0x170004DF")]
    public EEventTrigger Trigger
    {
      [Token(Token = "0x6003D3B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new EEventTrigger();
      }
    }

    [Token(Token = "0x170004E0")]
    public EEventType EventType
    {
      [Token(Token = "0x6003D3C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new EEventType();
      }
    }

    [Token(Token = "0x170004E1")]
    public EEventGimmick GimmickType
    {
      [Token(Token = "0x6003D3D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new EEventGimmick();
      }
    }

    [Token(Token = "0x170004E2")]
    public string StrValue
    {
      [Token(Token = "0x6003D3E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170004E3")]
    public int IntValue
    {
      [Token(Token = "0x6003D3F"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004E4")]
    public int Count
    {
      [Token(Token = "0x6003D40"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6003D41"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] set
      {
      }
    }

    [Token(Token = "0x170004E5")]
    public string Tag
    {
      [Token(Token = "0x6003D42"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170004E6")]
    public bool IsTriggerWithdraw
    {
      [Token(Token = "0x6003D43"), Address(RVA = "0x10FA7A0", Offset = "0x10F95A0", VA = "0x110FA7A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003D44")]
    [Address(RVA = "0x10FA740", Offset = "0x10F9540", VA = "0x110FA740")]
    public void Setup(EventTrigger src)
    {
    }

    [Token(Token = "0x6003D45")]
    [Address(RVA = "0x10FA200", Offset = "0x10F9000", VA = "0x110FA200")]
    public void CopyTo(EventTrigger dsc)
    {
    }

    [Token(Token = "0x6003D46")]
    [Address(RVA = "0x10FA260", Offset = "0x10F9060", VA = "0x110FA260")]
    public bool Deserialize(JSON_EventTrigger json) => new bool();

    [Token(Token = "0x6003D47")]
    [Address(RVA = "0x10FA450", Offset = "0x10F9250", VA = "0x110FA450")]
    public BuffAttachment MakeBuff(Unit gimmick, Unit target) => (BuffAttachment) null;

    [Token(Token = "0x6003D48")]
    [Address(RVA = "0x10FA2C0", Offset = "0x10F90C0", VA = "0x110FA2C0")]
    public void ExecuteGimmickEffect(Unit gimmick, Unit target, LogMapEvent log = null)
    {
    }

    [Token(Token = "0x6003D49")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EventTrigger()
    {
    }
  }
}
