// Decompiled with JetBrains decompiler
// Type: SRPG.SortMenuData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AEF")]
  public class SortMenuData
  {
    [Token(Token = "0x400D181")]
    [FieldOffset(Offset = "0x8")]
    public string method;
    [Token(Token = "0x400D182")]
    [FieldOffset(Offset = "0xC")]
    public bool ascending;
    [Token(Token = "0x400D183")]
    [FieldOffset(Offset = "0x10")]
    public string[] filters;
    [Token(Token = "0x400D184")]
    [FieldOffset(Offset = "0x14")]
    public bool isArtifactStone;

    [Token(Token = "0x600C440")]
    [Address(RVA = "0x8CE660", Offset = "0x8CD460", VA = "0x108CE660")]
    public void SetData(string _method, bool _ascending, string[] _filters, bool _isArtifactStone = true)
    {
    }

    [Token(Token = "0x600C441")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SortMenuData()
    {
    }
  }
}
