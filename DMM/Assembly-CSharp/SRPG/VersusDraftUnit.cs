// Decompiled with JetBrains decompiler
// Type: SRPG.VersusDraftUnit
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
  [Token(Token = "0x2002745")]
  [AddComponentMenu("UI/Multi/Versus/Draft/VersusDraftUnit")]
  public class VersusDraftUnit : MonoBehaviour
  {
    [Token(Token = "0x400B945")]
    [FieldOffset(Offset = "0x0")]
    private static VersusDraftList mVersusDraftList;
    [Token(Token = "0x400B946")]
    [FieldOffset(Offset = "0x4")]
    private static List<VersusDraftUnit> mCurrentSelected;
    [Token(Token = "0x400B947")]
    [FieldOffset(Offset = "0x8")]
    private static int mCursorIndex;
    [Token(Token = "0x400B948")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private UnitIcon mUnitIcon;
    [Token(Token = "0x400B949")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mCursorPlayer;
    [Token(Token = "0x400B94A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mCursorEnemy;
    [Token(Token = "0x400B94B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mSecretIcon;
    [Token(Token = "0x400B94C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mPickPlayer;
    [Token(Token = "0x400B94D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mPickEnemy;
    [Token(Token = "0x400B94E")]
    [FieldOffset(Offset = "0x24")]
    private UnitData mUnitData;
    [Token(Token = "0x400B94F")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsSelected;
    [Token(Token = "0x400B950")]
    [FieldOffset(Offset = "0x29")]
    private bool mIsHidden;

    [Token(Token = "0x1700184E")]
    public static VersusDraftList VersusDraftList
    {
      [Token(Token = "0x600B012"), Address(RVA = "0x74ED30", Offset = "0x74DB30", VA = "0x1074ED30")] get
      {
        return (VersusDraftList) null;
      }
      [Token(Token = "0x600B013"), Address(RVA = "0x74EDD0", Offset = "0x74DBD0", VA = "0x1074EDD0")] set
      {
      }
    }

    [Token(Token = "0x1700184F")]
    public static List<VersusDraftUnit> CurrentSelectCursors
    {
      [Token(Token = "0x600B014"), Address(RVA = "0x74ECF0", Offset = "0x74DAF0", VA = "0x1074ECF0")] get
      {
        return (List<VersusDraftUnit>) null;
      }
      [Token(Token = "0x600B015"), Address(RVA = "0x74ED70", Offset = "0x74DB70", VA = "0x1074ED70")] set
      {
      }
    }

    [Token(Token = "0x17001850")]
    public UnitData UnitData
    {
      [Token(Token = "0x600B016"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001851")]
    public bool IsSelected
    {
      [Token(Token = "0x600B017"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001852")]
    public bool IsHidden
    {
      [Token(Token = "0x600B018"), Address(RVA = "0x3550A0", Offset = "0x353EA0", VA = "0x103550A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B019")]
    [Address(RVA = "0x74EBA0", Offset = "0x74D9A0", VA = "0x1074EBA0")]
    public void SetUp(UnitData unit, Transform parent, bool is_hidden)
    {
    }

    [Token(Token = "0x600B01A")]
    [Address(RVA = "0x74E490", Offset = "0x74D290", VA = "0x1074E490")]
    public void OnClick(Button button)
    {
    }

    [Token(Token = "0x600B01B")]
    [Address(RVA = "0x74E5F0", Offset = "0x74D3F0", VA = "0x1074E5F0")]
    public static void ResetSelectUnit()
    {
    }

    [Token(Token = "0x600B01C")]
    [Address(RVA = "0x74E7B0", Offset = "0x74D5B0", VA = "0x1074E7B0")]
    public void SelectUnit(bool isPlayer = true)
    {
    }

    [Token(Token = "0x600B01D")]
    [Address(RVA = "0x74E350", Offset = "0x74D150", VA = "0x1074E350")]
    public void DecideUnit(bool isPlayer = true)
    {
    }

    [Token(Token = "0x600B01E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public VersusDraftUnit()
    {
    }

    [Token(Token = "0x600B01F")]
    [Address(RVA = "0x74EC60", Offset = "0x74DA60", VA = "0x1074EC60")]
    static VersusDraftUnit()
    {
    }
  }
}
