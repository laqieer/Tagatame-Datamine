// Decompiled with JetBrains decompiler
// Type: UnManagedAssetList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000081")]
public class UnManagedAssetList
{
  [Token(Token = "0x400028F")]
  [FieldOffset(Offset = "0x8")]
  public Dictionary<string, UnManagedAssetList.Item> mAssets;

  [Token(Token = "0x60002F1")]
  [Address(RVA = "0xB8E980", Offset = "0xB8D780", VA = "0x10B8E980")]
  public void Setup(string path)
  {
  }

  [Token(Token = "0x60002F2")]
  [Address(RVA = "0xB8E910", Offset = "0xB8D710", VA = "0x10B8E910")]
  public int GetSize(string name) => new int();

  [Token(Token = "0x60002F3")]
  [Address(RVA = "0xB8E8B0", Offset = "0xB8D6B0", VA = "0x10B8E8B0")]
  public UnManagedAssetList.Item FindByItemName(string name) => (UnManagedAssetList.Item) null;

  [Token(Token = "0x60002F4")]
  [Address(RVA = "0xB8EBB0", Offset = "0xB8D9B0", VA = "0x10B8EBB0")]
  public UnManagedAssetList()
  {
  }

  [Token(Token = "0x2000082")]
  public class Item
  {
    [Token(Token = "0x4000290")]
    [FieldOffset(Offset = "0x8")]
    private string m_Path;
    [Token(Token = "0x4000291")]
    [FieldOffset(Offset = "0xC")]
    private int m_Size;

    [Token(Token = "0x17000074")]
    public string Path
    {
      [Token(Token = "0x60002F5"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000075")]
    public int Size
    {
      [Token(Token = "0x60002F6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000076")]
    public bool IsAssetDownloadApproved
    {
      [Token(Token = "0x60002F7"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
      [Token(Token = "0x60002F8"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] private set
      {
      }
    }

    [Token(Token = "0x60002F9")]
    [Address(RVA = "0x3217D0", Offset = "0x3205D0", VA = "0x103217D0")]
    public Item(string path, int size)
    {
    }

    [Token(Token = "0x60002FA")]
    [Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")]
    public void SetDownloadApproved(bool value)
    {
    }

    [Token(Token = "0x60002FB")]
    [Address(RVA = "0x9E1790", Offset = "0x9E0590", VA = "0x109E1790")]
    public void ResetDownloadApproved()
    {
    }
  }
}
