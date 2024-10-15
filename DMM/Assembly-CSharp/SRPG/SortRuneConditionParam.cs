// Decompiled with JetBrains decompiler
// Type: SRPG.SortRuneConditionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D50")]
  public class SortRuneConditionParam
  {
    [Token(Token = "0x4007357")]
    [FieldOffset(Offset = "0x8")]
    public SortRuneParam parent;
    [Token(Token = "0x4007358")]
    [FieldOffset(Offset = "0xC")]
    public string cnds_iname;
    [Token(Token = "0x4007359")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x400735A")]
    [FieldOffset(Offset = "0x14")]
    public eRuneSortType sort_type;

    [Token(Token = "0x6007813")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public SortRuneConditionParam(SortRuneParam _parent)
    {
    }

    [Token(Token = "0x6007814")]
    [Address(RVA = "0x39FF00", Offset = "0x39ED00", VA = "0x1039FF00")]
    public void Deserialize(JSON_SortRuneConditionParam json)
    {
    }

    [Token(Token = "0x17000FEA")]
    public string PrefsKey
    {
      [Token(Token = "0x6007815"), Address(RVA = "0x39FF40", Offset = "0x39ED40", VA = "0x1039FF40")] get
      {
        return (string) null;
      }
    }
  }
}
