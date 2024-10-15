// Decompiled with JetBrains decompiler
// Type: SRPG.EvaluationParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ACE")]
  public class EvaluationParam
  {
    [Token(Token = "0x4006370")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006371")]
    [FieldOffset(Offset = "0xC")]
    public OInt value;
    [Token(Token = "0x4006372")]
    [FieldOffset(Offset = "0x20")]
    public StatusParam status;

    [Token(Token = "0x6006E76")]
    [Address(RVA = "0x360D80", Offset = "0x35FB80", VA = "0x10360D80")]
    public bool Deserialize(JSON_EvaluationParam json) => new bool();

    [Token(Token = "0x6006E77")]
    [Address(RVA = "0x360EE0", Offset = "0x35FCE0", VA = "0x10360EE0")]
    public EvaluationParam()
    {
    }
  }
}
