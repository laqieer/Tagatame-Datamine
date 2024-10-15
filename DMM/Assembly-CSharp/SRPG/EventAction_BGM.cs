// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_BGM
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011F2")]
  [EventActionInfo("BGM再生", "BGMを再生します", 7368789, 8947780)]
  public class EventAction_BGM : EventAction
  {
    [Token(Token = "0x4004144")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int DEMO_BGM_ST;
    [Token(Token = "0x4004145")]
    [FieldOffset(Offset = "0x4")]
    public static readonly int DEMO_BGM_ED;
    [Token(Token = "0x4004146")]
    [FieldOffset(Offset = "0x18")]
    public string BGM;

    [Token(Token = "0x6004C46")]
    [Address(RVA = "0x1216490", Offset = "0x1215290", VA = "0x11216490", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C47")]
    [Address(RVA = "0x12163D0", Offset = "0x12151D0", VA = "0x112163D0", Slot = "17")]
    public override string[] GetUnManagedAssetListData() => (string[]) null;

    [Token(Token = "0x6004C48")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public EventAction_BGM()
    {
    }

    [Token(Token = "0x6004C49")]
    [Address(RVA = "0x1216790", Offset = "0x1215590", VA = "0x11216790")]
    static EventAction_BGM()
    {
    }
  }
}
