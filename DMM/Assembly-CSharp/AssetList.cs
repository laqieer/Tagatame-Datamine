// Decompiled with JetBrains decompiler
// Type: AssetList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable
[Token(Token = "0x200007D")]
public class AssetList
{
  [Token(Token = "0x4000277")]
  [FieldOffset(Offset = "0x8")]
  private int mRevision;
  [Token(Token = "0x4000278")]
  [FieldOffset(Offset = "0xC")]
  private List<AssetList.Item> mItems;
  [Token(Token = "0x4000279")]
  [FieldOffset(Offset = "0x10")]
  private Dictionary<string, AssetList.Item> mPath2Item;
  [Token(Token = "0x400027A")]
  [FieldOffset(Offset = "0x14")]
  private Dictionary<uint, AssetList.Item> mID2Item;
  [Token(Token = "0x400027B")]
  private const string AssetsPrefix = "Assets/";
  [Token(Token = "0x400027C")]
  private const string ResourcesPrefix = "Assets/Resources/";
  [Token(Token = "0x400027D")]
  private const string StreamingAssetsPrefix = "Assets/StreamingAssets/";

  [Token(Token = "0x17000071")]
  public int Revision
  {
    [Token(Token = "0x60002CC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
    {
      return new int();
    }
    [Token(Token = "0x60002CD"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] set
    {
    }
  }

  [Token(Token = "0x17000072")]
  public AssetList.Item[] Assets
  {
    [Token(Token = "0x60002CE"), Address(RVA = "0x2DBD50", Offset = "0x2DAB50", VA = "0x102DBD50")] get
    {
      return (AssetList.Item[]) null;
    }
  }

  [Token(Token = "0x60002CF")]
  [Address(RVA = "0x2DBB50", Offset = "0x2DA950", VA = "0x102DBB50")]
  public AssetList()
  {
  }

  [Token(Token = "0x60002D0")]
  [Address(RVA = "0x2DBC50", Offset = "0x2DAA50", VA = "0x102DBC50")]
  public AssetList(int revision)
  {
  }

  [Token(Token = "0x60002D1")]
  [Address(RVA = "0x2DAF50", Offset = "0x2D9D50", VA = "0x102DAF50")]
  public void SetPath(AssetList.Item item, string path)
  {
  }

  [Token(Token = "0x60002D2")]
  [Address(RVA = "0x2D86A0", Offset = "0x2D74A0", VA = "0x102D86A0")]
  public AssetList.Item AddItem(string IDStr) => (AssetList.Item) null;

  [Token(Token = "0x60002D3")]
  [Address(RVA = "0x2D86D0", Offset = "0x2D74D0", VA = "0x102D86D0")]
  public AssetList.Item AddItem(uint ID) => (AssetList.Item) null;

  [Token(Token = "0x60002D4")]
  [Address(RVA = "0x2D9620", Offset = "0x2D8420", VA = "0x102D9620")]
  public AssetList.Item FindItemByID(string idstr) => (AssetList.Item) null;

  [Token(Token = "0x60002D5")]
  [Address(RVA = "0x2D9550", Offset = "0x2D8350", VA = "0x102D9550")]
  public AssetList.Item FindItemByID(uint id) => (AssetList.Item) null;

  [Token(Token = "0x60002D6")]
  [Address(RVA = "0x2D99C0", Offset = "0x2D87C0", VA = "0x102D99C0")]
  public AssetList.Item GetItem(int idx) => (AssetList.Item) null;

  [Token(Token = "0x60002D7")]
  [Address(RVA = "0x2DB000", Offset = "0x2D9E00", VA = "0x102DB000")]
  public void UpdateIndex()
  {
  }

  [Token(Token = "0x60002D8")]
  [Address(RVA = "0x2D9630", Offset = "0x2D8430", VA = "0x102D9630")]
  public AssetList.Item FindItemByPath(string path) => (AssetList.Item) null;

  [Token(Token = "0x60002D9")]
  [Address(RVA = "0x2D95B0", Offset = "0x2D83B0", VA = "0x102D95B0")]
  public AssetList.Item FastFindItemByID(string idstr) => (AssetList.Item) null;

  [Token(Token = "0x60002DA")]
  [Address(RVA = "0x2D9550", Offset = "0x2D8350", VA = "0x102D9550")]
  public AssetList.Item FastFindItemByID(uint id) => (AssetList.Item) null;

  [Token(Token = "0x60002DB")]
  [Address(RVA = "0x2DAE50", Offset = "0x2D9C50", VA = "0x102DAE50")]
  public void SetDependencies(uint ID, uint[] dependencies)
  {
  }

  [Token(Token = "0x60002DC")]
  [Address(RVA = "0x2D9700", Offset = "0x2D8500", VA = "0x102D9700")]
  public List<AssetList.Item> GetAssetDependencies(string path) => (List<AssetList.Item>) null;

  [Token(Token = "0x60002DD")]
  [Address(RVA = "0x2D9850", Offset = "0x2D8650", VA = "0x102D9850")]
  private void GetAssetDependencies(ref Dictionary<uint, AssetList.Item> dependencies, string path)
  {
  }

  [Token(Token = "0x60002DE")]
  [Address(RVA = "0x2DA440", Offset = "0x2D9240", VA = "0x102DA440")]
  public void ReadFromMemory(string src)
  {
  }

  [Token(Token = "0x60002DF")]
  [Address(RVA = "0x2D9400", Offset = "0x2D8200", VA = "0x102D9400")]
  public void CreateAssetRevision(string path)
  {
  }

  [Token(Token = "0x60002E0")]
  [Address(RVA = "0x2D8C20", Offset = "0x2D7A20", VA = "0x102D8C20")]
  public void CreateAssetList(string path)
  {
  }

  [Token(Token = "0x60002E1")]
  [Address(RVA = "0x2DA350", Offset = "0x2D9150", VA = "0x102DA350")]
  public void ReadAssetList(string path)
  {
  }

  [Token(Token = "0x60002E2")]
  [Address(RVA = "0x2D9A20", Offset = "0x2D8820", VA = "0x102D9A20")]
  public void ReadAssetListProc(string path, ref List<AssetList.Item> ItemList)
  {
  }

  [Token(Token = "0x60002E3")]
  [Address(RVA = "0x2DAA50", Offset = "0x2D9850", VA = "0x102DAA50")]
  public void ReadSkipAssetList(string path, ref Dictionary<uint, AssetList.Item> ItemMap)
  {
  }

  [Token(Token = "0x60002E4")]
  [Address(RVA = "0x2DB080", Offset = "0x2D9E80", VA = "0x102DB080")]
  public void WriteTo(string path)
  {
  }

  [Token(Token = "0x60002E5")]
  [Address(RVA = "0x2D8820", Offset = "0x2D7620", VA = "0x102D8820")]
  public void ConvertAssetsPath()
  {
  }

  [Token(Token = "0x200007E")]
  public class Item
  {
    [Token(Token = "0x400027E")]
    [FieldOffset(Offset = "0x8")]
    public uint ID;
    [Token(Token = "0x400027F")]
    [FieldOffset(Offset = "0xC")]
    public string IDStr;
    [Token(Token = "0x4000280")]
    [FieldOffset(Offset = "0x10")]
    public int Size;
    [Token(Token = "0x4000281")]
    [FieldOffset(Offset = "0x14")]
    public int CompressedSize;
    [Token(Token = "0x4000282")]
    [FieldOffset(Offset = "0x18")]
    public string Path;
    [Token(Token = "0x4000283")]
    [FieldOffset(Offset = "0x1C")]
    public int PathHash;
    [Token(Token = "0x4000284")]
    [FieldOffset(Offset = "0x20")]
    public uint Hash;
    [Token(Token = "0x4000285")]
    [FieldOffset(Offset = "0x24")]
    public AssetBundleFlags Flags;
    [Token(Token = "0x4000286")]
    [FieldOffset(Offset = "0x28")]
    public AssetList.Item[] Dependencies;
    [Token(Token = "0x4000287")]
    [FieldOffset(Offset = "0x2C")]
    public AssetList.Item[] AdditionalDependencies;
    [Token(Token = "0x4000288")]
    [FieldOffset(Offset = "0x30")]
    public AssetList.Item[] AdditionalStreamingAssets;
    [Token(Token = "0x4000289")]
    [FieldOffset(Offset = "0x34")]
    public bool Exist;
    [Token(Token = "0x400028A")]
    [FieldOffset(Offset = "0x38")]
    public int Index;
    [Token(Token = "0x400028B")]
    [FieldOffset(Offset = "0x3C")]
    public StackTrace DownloadCaller;

    [Token(Token = "0x60002E6")]
    [Address(RVA = "0xB8D4D0", Offset = "0xB8C2D0", VA = "0x10B8D4D0")]
    public void SetPath(string _path)
    {
    }

    [Token(Token = "0x60002E7")]
    [Address(RVA = "0xB8D470", Offset = "0xB8C270", VA = "0x10B8D470")]
    public void SetDownloadCaller()
    {
    }

    [Token(Token = "0x17000073")]
    public bool IsAssetDownloadApproved
    {
      [Token(Token = "0x60002E8"), Address(RVA = "0x288080", Offset = "0x286E80", VA = "0x10288080")] get
      {
        return new bool();
      }
      [Token(Token = "0x60002E9"), Address(RVA = "0x2883C0", Offset = "0x2871C0", VA = "0x102883C0")] private set
      {
      }
    }

    [Token(Token = "0x60002EA")]
    [Address(RVA = "0x2883C0", Offset = "0x2871C0", VA = "0x102883C0")]
    public void SetDownloadApproved(bool value)
    {
    }

    [Token(Token = "0x60002EB")]
    [Address(RVA = "0xB8D460", Offset = "0xB8C260", VA = "0x10B8D460")]
    public void ResetDownloadApproved()
    {
    }

    [Token(Token = "0x60002EC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Item()
    {
    }
  }
}
