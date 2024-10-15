// Decompiled with JetBrains decompiler
// Type: SRPG.GachaManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F13")]
  [AddComponentMenu("Common/GachaManager")]
  public class GachaManager : MonoSingleton<GachaManager>
  {
    [Token(Token = "0x4002EC3")]
    [FieldOffset(Offset = "0xC")]
    public GameObject GachaPanel;
    [Token(Token = "0x4002EC4")]
    [FieldOffset(Offset = "0x10")]
    private List<GachaTopParam> GachaList;
    [Token(Token = "0x4002EC5")]
    [FieldOffset(Offset = "0x14")]
    public Button NextGachaButton;
    [Token(Token = "0x4002EC6")]
    [FieldOffset(Offset = "0x18")]
    public Button PrevGachaButton;
    [Token(Token = "0x4002EC7")]
    [FieldOffset(Offset = "0x1C")]
    private List<GachaTopParam2> mGachaListRare;
    [Token(Token = "0x4002EC8")]
    [FieldOffset(Offset = "0x20")]
    private List<GachaTopParam2> mGachaListNormal;
    [Token(Token = "0x4002EC9")]
    [FieldOffset(Offset = "0x24")]
    private List<GachaTopParam2> mGachaListTicket;
    [Token(Token = "0x4002ECA")]
    [FieldOffset(Offset = "0x28")]
    private List<GachaTopParam2> mGachaListArtifact;
    [Token(Token = "0x4002ECB")]
    [FieldOffset(Offset = "0x2C")]
    private List<GachaTopParam2> mGachaListSpecial;
    [Token(Token = "0x4002ECC")]
    [FieldOffset(Offset = "0x30")]
    private int mUseTicketNum;
    [Token(Token = "0x4002ECD")]
    [FieldOffset(Offset = "0x34")]
    private string mUseTicketIname;
    [Token(Token = "0x4002ECE")]
    [FieldOffset(Offset = "0x38")]
    private int mItemExecuteNum;
    [Token(Token = "0x4002ECF")]
    [FieldOffset(Offset = "0x3C")]
    private int mCurrentGachaIndex;
    [Token(Token = "0x4002ED0")]
    [FieldOffset(Offset = "0x40")]
    private bool mInitalize;
    [Token(Token = "0x4002ED1")]
    [FieldOffset(Offset = "0x44")]
    private GachaOptionData m_gacha_option_data;

    [Token(Token = "0x17000527")]
    public GachaTopParam2[] GachaListRare
    {
      [Token(Token = "0x6003ECE"), Address(RVA = "0x1177690", Offset = "0x1176490", VA = "0x11177690")] get
      {
        return (GachaTopParam2[]) null;
      }
    }

    [Token(Token = "0x17000528")]
    public GachaTopParam2[] GachaListNormal
    {
      [Token(Token = "0x6003ECF"), Address(RVA = "0x1177650", Offset = "0x1176450", VA = "0x11177650")] get
      {
        return (GachaTopParam2[]) null;
      }
    }

    [Token(Token = "0x17000529")]
    public GachaTopParam2[] GachaListTicket
    {
      [Token(Token = "0x6003ED0"), Address(RVA = "0x1177710", Offset = "0x1176510", VA = "0x11177710")] get
      {
        return (GachaTopParam2[]) null;
      }
    }

    [Token(Token = "0x1700052A")]
    public GachaTopParam2[] GachaListArtifact
    {
      [Token(Token = "0x6003ED1"), Address(RVA = "0x1177610", Offset = "0x1176410", VA = "0x11177610")] get
      {
        return (GachaTopParam2[]) null;
      }
    }

    [Token(Token = "0x1700052B")]
    public GachaTopParam2[] GachaListSpecial
    {
      [Token(Token = "0x6003ED2"), Address(RVA = "0x11776D0", Offset = "0x11764D0", VA = "0x111776D0")] get
      {
        return (GachaTopParam2[]) null;
      }
    }

    [Token(Token = "0x1700052C")]
    public int UseTicketNum
    {
      [Token(Token = "0x6003ED3"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
      [Token(Token = "0x6003ED4"), Address(RVA = "0x373930", Offset = "0x372730", VA = "0x10373930")] set
      {
      }
    }

    [Token(Token = "0x1700052D")]
    public string UseTicketIname
    {
      [Token(Token = "0x6003ED5"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6003ED6"), Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")] set
      {
      }
    }

    [Token(Token = "0x1700052E")]
    public int ItemExecuteNum
    {
      [Token(Token = "0x6003ED7"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6003ED8"), Address(RVA = "0x374A30", Offset = "0x373830", VA = "0x10374A30")] set
      {
      }
    }

    [Token(Token = "0x1700052F")]
    public int CurrentGachaIndex
    {
      [Token(Token = "0x6003ED9"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return new int();
      }
      [Token(Token = "0x6003EDA"), Address(RVA = "0x373920", Offset = "0x372720", VA = "0x10373920")] set
      {
      }
    }

    [Token(Token = "0x6003EDB")]
    [Address(RVA = "0x1176620", Offset = "0x1175420", VA = "0x11176620")]
    public GachaTopParam GetCurrentGacha() => (GachaTopParam) null;

    [Token(Token = "0x6003EDC")]
    [Address(RVA = "0x1176730", Offset = "0x1175530", VA = "0x11176730", Slot = "4")]
    protected override void Initialize()
    {
    }

    [Token(Token = "0x6003EDD")]
    [Address(RVA = "0x1177520", Offset = "0x1176320", VA = "0x11177520")]
    private void Start()
    {
    }

    [Token(Token = "0x6003EDE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void RefreshGachaList()
    {
    }

    [Token(Token = "0x6003EDF")]
    [Address(RVA = "0x1176770", Offset = "0x1175570", VA = "0x11176770")]
    private void OnShiftGacha(Button button)
    {
    }

    [Token(Token = "0x6003EE0")]
    [Address(RVA = "0x11774B0", Offset = "0x11762B0", VA = "0x111774B0")]
    private IEnumerator ShiftGachaAsync(int index) => (IEnumerator) null;

    [Token(Token = "0x6003EE1")]
    [Address(RVA = "0x1176890", Offset = "0x1175690", VA = "0x11176890")]
    private void SetupGachaList2(GachaParam[] gparams)
    {
    }

    [Token(Token = "0x6003EE2")]
    [Address(RVA = "0x11764C0", Offset = "0x11752C0", VA = "0x111764C0")]
    private GachaTopParam2 Deserialize(GachaParam param) => (GachaTopParam2) null;

    [Token(Token = "0x6003EE3")]
    [Address(RVA = "0x1176CC0", Offset = "0x1175AC0", VA = "0x11176CC0")]
    private void SetupGachaList(GachaParam[] gparams)
    {
    }

    [Token(Token = "0x6003EE4")]
    [Address(RVA = "0x1176670", Offset = "0x1175470", VA = "0x11176670")]
    private int GetGachaParamIndex(List<GachaTopParam> list, string iname) => new int();

    [Token(Token = "0x17000530")]
    public GachaOptionData OptionData
    {
      [Token(Token = "0x6003EE5"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (GachaOptionData) null;
      }
    }

    [Token(Token = "0x6003EE6")]
    [Address(RVA = "0x1176860", Offset = "0x1175660", VA = "0x11176860")]
    public void SetGachaOption(Json_GachaOption json)
    {
    }

    [Token(Token = "0x6003EE7")]
    [Address(RVA = "0x11775A0", Offset = "0x11763A0", VA = "0x111775A0")]
    public GachaManager()
    {
    }
  }
}
