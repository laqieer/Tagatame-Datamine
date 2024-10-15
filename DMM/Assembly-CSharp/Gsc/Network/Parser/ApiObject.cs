// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Parser.ApiObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.DOM.Generic;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Network.Parser
{
  [Token(Token = "0x20035A2")]
  public class ApiObject : Object
  {
    [Token(Token = "0x600EE00")]
    [Address(RVA = "0xB00B40", Offset = "0xAFF940", VA = "0x10B00B40")]
    public void Add(string name, IList<bool> values)
    {
    }

    [Token(Token = "0x600EE01")]
    [Address(RVA = "0xB00040", Offset = "0xAFEE40", VA = "0x10B00040")]
    public void Add(string name, IList<string> values)
    {
    }

    [Token(Token = "0x600EE02")]
    [Address(RVA = "0xB00970", Offset = "0xAFF770", VA = "0x10B00970")]
    public void Add(string name, IList<int> values)
    {
    }

    [Token(Token = "0x600EE03")]
    [Address(RVA = "0xB005C0", Offset = "0xAFF3C0", VA = "0x10B005C0")]
    public void Add(string name, IList<uint> values)
    {
    }

    [Token(Token = "0x600EE04")]
    [Address(RVA = "0xB00220", Offset = "0xAFF020", VA = "0x10B00220")]
    public void Add(string name, IList<long> values)
    {
    }

    [Token(Token = "0x600EE05")]
    [Address(RVA = "0xB007A0", Offset = "0xAFF5A0", VA = "0x10B007A0")]
    public void Add(string name, IList<ulong> values)
    {
    }

    [Token(Token = "0x600EE06")]
    [Address(RVA = "0xAFFE70", Offset = "0xAFEC70", VA = "0x10AFFE70")]
    public void Add(string name, IList<float> values)
    {
    }

    [Token(Token = "0x600EE07")]
    [Address(RVA = "0xB003F0", Offset = "0xAFF1F0", VA = "0x10B003F0")]
    public void Add(string name, IList<double> values)
    {
    }

    [Token(Token = "0x600EE08")]
    public void Add<T>(string name, IList<T> values) where T : Object
    {
    }

    [Token(Token = "0x600EE09")]
    [Address(RVA = "0xB00D10", Offset = "0xAFFB10", VA = "0x10B00D10")]
    public ApiObject()
    {
    }
  }
}
