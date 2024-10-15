// Decompiled with JetBrains decompiler
// Type: SRPG.TargetID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011EA")]
  [Serializable]
  public struct TargetID
  {
    [Token(Token = "0x400412F")]
    [FieldOffset(Offset = "0x0")]
    public TargetID.IDType Type;
    [Token(Token = "0x4004130")]
    [FieldOffset(Offset = "0x4")]
    public string ID;

    [Token(Token = "0x20011EB")]
    public enum IDType
    {
      [Token(Token = "0x4004132")] ObjectID,
      [Token(Token = "0x4004133")] UnitID,
      [Token(Token = "0x4004134")] ActorID,
    }
  }
}
