// Decompiled with JetBrains decompiler
// Type: SRPG.ArtiFilterCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002ACA")]
  [AddComponentMenu("UI/SortFilter/ArtiFilterCategory")]
  public class ArtiFilterCategory : MonoBehaviour
  {
    [Token(Token = "0x400D0B4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TextCategory;
    [Token(Token = "0x400D0B5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text TextSubTitle;
    [Token(Token = "0x400D0B6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject GoTabParent;
    [Token(Token = "0x400D0B7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ArtiFilterItemFilter TemplateFilter;
    [Token(Token = "0x400D0B8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject GoHeader;
    [Token(Token = "0x400D0B9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject GoSubHeader;
    [Token(Token = "0x400D0BA")]
    [FieldOffset(Offset = "0x24")]
    private ArtiFilterWindow mParent;
    [Token(Token = "0x400D0BB")]
    [FieldOffset(Offset = "0x28")]
    private int mIndex;
    [Token(Token = "0x400D0BC")]
    [FieldOffset(Offset = "0x2C")]
    private FilterArtifactParam mFilterParam;
    [Token(Token = "0x400D0BD")]
    [FieldOffset(Offset = "0x30")]
    private List<ArtiFilterItemFilter> mFilterList;

    [Token(Token = "0x17001A02")]
    public int Index
    {
      [Token(Token = "0x600C363"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001A03")]
    public FilterArtifactParam FilterParam
    {
      [Token(Token = "0x600C364"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (FilterArtifactParam) null;
      }
    }

    [Token(Token = "0x17001A04")]
    public List<ArtiFilterItemFilter> FilterList
    {
      [Token(Token = "0x600C365"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (List<ArtiFilterItemFilter>) null;
      }
    }

    [Token(Token = "0x600C366")]
    [Address(RVA = "0x8BA150", Offset = "0x8B8F50", VA = "0x108BA150")]
    private void Start()
    {
    }

    [Token(Token = "0x600C367")]
    [Address(RVA = "0x8B9C80", Offset = "0x8B8A80", VA = "0x108B9C80")]
    public void Init(ArtiFilterWindow parent, int index, FilterArtifactParam filter_param)
    {
    }

    [Token(Token = "0x600C368")]
    [Address(RVA = "0x8BA0C0", Offset = "0x8B8EC0", VA = "0x108BA0C0")]
    private void OnTapFilterItem(bool val, ArtiFilterItemFilter item)
    {
    }

    [Token(Token = "0x600C369")]
    [Address(RVA = "0x8BA1C0", Offset = "0x8B8FC0", VA = "0x108BA1C0")]
    public ArtiFilterCategory()
    {
    }
  }
}
