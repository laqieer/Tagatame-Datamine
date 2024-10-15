// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.IValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.DOM
{
  [Token(Token = "0x20035B8")]
  public interface IValue
  {
    [Token(Token = "0x600EE92")]
    bool IsNull();

    [Token(Token = "0x600EE93")]
    bool IsObject();

    [Token(Token = "0x600EE94")]
    bool IsArray();

    [Token(Token = "0x600EE95")]
    bool IsBool();

    [Token(Token = "0x600EE96")]
    bool IsString();

    [Token(Token = "0x600EE97")]
    bool IsInt();

    [Token(Token = "0x600EE98")]
    bool IsUInt();

    [Token(Token = "0x600EE99")]
    bool IsLong();

    [Token(Token = "0x600EE9A")]
    bool IsULong();

    [Token(Token = "0x600EE9B")]
    bool IsFloat();

    [Token(Token = "0x600EE9C")]
    bool IsDouble();

    [Token(Token = "0x600EE9D")]
    IObject GetObject();

    [Token(Token = "0x600EE9E")]
    IArray GetArray();

    [Token(Token = "0x600EE9F")]
    bool ToBool();

    [Token(Token = "0x600EEA0")]
    string ToString();

    [Token(Token = "0x600EEA1")]
    int ToInt();

    [Token(Token = "0x600EEA2")]
    uint ToUInt();

    [Token(Token = "0x600EEA3")]
    long ToLong();

    [Token(Token = "0x600EEA4")]
    ulong ToULong();

    [Token(Token = "0x600EEA5")]
    float ToFloat();

    [Token(Token = "0x600EEA6")]
    double ToDouble();

    [Token(Token = "0x17002211")]
    IValue this[int index] { [Token(Token = "0x600EEA7")] get; }

    [Token(Token = "0x17002212")]
    IValue this[string name] { [Token(Token = "0x600EEA8")] get; }
  }
}
