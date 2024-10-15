// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceRequestParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FF9")]
  [Serializable]
  public class ResonanceRequestParam
  {
    [Token(Token = "0x400EB38")]
    [FieldOffset(Offset = "0x8")]
    public long parent_unit_id;
    [Token(Token = "0x400EB39")]
    [FieldOffset(Offset = "0x10")]
    public long child_unit_id;

    [Token(Token = "0x600DC4F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ResonanceRequestParam()
    {
    }
  }
}
