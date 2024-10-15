// Decompiled with JetBrains decompiler
// Type: SRPG.GachaResultUnitDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200244C")]
  [AddComponentMenu("UI/GachaResultUnitDetail")]
  public class GachaResultUnitDetail : MonoBehaviour
  {
    [Token(Token = "0x400A4D4")]
    [FieldOffset(Offset = "0xC")]
    public string PreviewParentID;
    [Token(Token = "0x400A4D5")]
    [FieldOffset(Offset = "0x10")]
    public string PreviewBaseID;
    [Token(Token = "0x400A4D6")]
    [FieldOffset(Offset = "0x14")]
    private string BGUnitImageID;
    [Token(Token = "0x400A4D7")]
    [FieldOffset(Offset = "0x18")]
    private string BGUnitMaskImageID;
    [Token(Token = "0x400A4D8")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject UnitInfo;
    [Token(Token = "0x400A4D9")]
    [FieldOffset(Offset = "0x20")]
    public GameObject JobInfo;
    [Token(Token = "0x400A4DA")]
    [FieldOffset(Offset = "0x24")]
    public GameObject LeaderSkillInfo;
    [Token(Token = "0x400A4DB")]
    [FieldOffset(Offset = "0x28")]
    public GameObject AbilityTemplate;
    [Token(Token = "0x400A4DC")]
    [FieldOffset(Offset = "0x2C")]
    public Text UnitLv;
    [Token(Token = "0x400A4DD")]
    [FieldOffset(Offset = "0x30")]
    public Text UnitLvMax;
    [Token(Token = "0x400A4DE")]
    [FieldOffset(Offset = "0x34")]
    public Text Status_HP;
    [Token(Token = "0x400A4DF")]
    [FieldOffset(Offset = "0x38")]
    public Text Status_Atk;
    [Token(Token = "0x400A4E0")]
    [FieldOffset(Offset = "0x3C")]
    public Text Status_Def;
    [Token(Token = "0x400A4E1")]
    [FieldOffset(Offset = "0x40")]
    public Text Status_Mag;
    [Token(Token = "0x400A4E2")]
    [FieldOffset(Offset = "0x44")]
    public Text Status_Mnd;
    [Token(Token = "0x400A4E3")]
    [FieldOffset(Offset = "0x48")]
    public Text Status_Rec;
    [Token(Token = "0x400A4E4")]
    [FieldOffset(Offset = "0x4C")]
    public Text Status_Dex;
    [Token(Token = "0x400A4E5")]
    [FieldOffset(Offset = "0x50")]
    public Text Status_Speed;
    [Token(Token = "0x400A4E6")]
    [FieldOffset(Offset = "0x54")]
    public Text Status_Cri;
    [Token(Token = "0x400A4E7")]
    [FieldOffset(Offset = "0x58")]
    public Text Status_Luck;
    [Token(Token = "0x400A4E8")]
    [FieldOffset(Offset = "0x5C")]
    public Text Status_Renkei;
    [Token(Token = "0x400A4E9")]
    [FieldOffset(Offset = "0x60")]
    public Text Status_MP;
    [Token(Token = "0x400A4EA")]
    [FieldOffset(Offset = "0x64")]
    public Text Status_MPStart;
    [Token(Token = "0x400A4EB")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text Status_Move;
    [Token(Token = "0x400A4EC")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private Text Status_Jump;
    [Token(Token = "0x400A4ED")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject JobData01;
    [Token(Token = "0x400A4EE")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private GameObject JobData02;
    [Token(Token = "0x400A4EF")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject JobData03;
    [Token(Token = "0x400A4F0")]
    [FieldOffset(Offset = "0x7C")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400A4F1")]
    [FieldOffset(Offset = "0x80")]
    private int mCurrentUnitIndex;
    [Token(Token = "0x400A4F2")]
    [FieldOffset(Offset = "0x84")]
    private Text[] mStatusParamSlots;
    [Token(Token = "0x400A4F3")]
    [FieldOffset(Offset = "0x88")]
    private Transform mPreviewParent;
    [Token(Token = "0x400A4F4")]
    [FieldOffset(Offset = "0x8C")]
    private GameObject mPreviewBase;
    [Token(Token = "0x400A4F5")]
    [FieldOffset(Offset = "0x90")]
    private UnitPreview mCurrentPreview;
    [Token(Token = "0x400A4F6")]
    [FieldOffset(Offset = "0x94")]
    private List<UnitPreview> mPreviewControllers;
    [Token(Token = "0x400A4F7")]
    [FieldOffset(Offset = "0x98")]
    private RawImage mBGUnitImage;
    [Token(Token = "0x400A4F8")]
    [FieldOffset(Offset = "0x9C")]
    private RawImage mBGUnitMaskImage;
    [Token(Token = "0x400A4F9")]
    [FieldOffset(Offset = "0xA0")]
    public Button LeaderSkillDetailButton;
    [Token(Token = "0x400A4FA")]
    [FieldOffset(Offset = "0xA4")]
    private GameObject mLeaderSkillDetail;
    [Token(Token = "0x400A4FB")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject Prefab_LeaderSkillDetail;
    [Token(Token = "0x400A4FC")]
    [FieldOffset(Offset = "0xAC")]
    [SerializeField]
    private string Prefab_LeaderSkillDetailPath;
    [Token(Token = "0x400A4FD")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text LeaderSkillName;
    [Token(Token = "0x400A4FE")]
    [FieldOffset(Offset = "0xB4")]
    private bool mDesiredPreviewVisibility;
    [Token(Token = "0x400A4FF")]
    [FieldOffset(Offset = "0xB5")]
    private bool mUpdatePreviewVisibility;
    [Token(Token = "0x400A500")]
    [FieldOffset(Offset = "0xB8")]
    private float mBGUnitImgAlphaStart;
    [Token(Token = "0x400A501")]
    [FieldOffset(Offset = "0xBC")]
    private float mBGUnitImgAlphaEnd;
    [Token(Token = "0x400A502")]
    [FieldOffset(Offset = "0xC0")]
    private float mBGUnitImgFadeTime;
    [Token(Token = "0x400A503")]
    [FieldOffset(Offset = "0xC4")]
    private float mBGUnitImgFadeTimeMax;
    [Token(Token = "0x400A504")]
    [FieldOffset(Offset = "0xC8")]
    private List<GameObject> mAbilits;

    [Token(Token = "0x6009E86")]
    [Address(RVA = "0x613050", Offset = "0x611E50", VA = "0x10613050")]
    private IEnumerator ShowLeaderSkillDetail(string _path) => (IEnumerator) null;

    [Token(Token = "0x6009E87")]
    [Address(RVA = "0x6113A0", Offset = "0x6101A0", VA = "0x106113A0")]
    private void OpenLeaderSkillDetail()
    {
    }

    [Token(Token = "0x6009E88")]
    [Address(RVA = "0x6130C0", Offset = "0x611EC0", VA = "0x106130C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009E89")]
    [Address(RVA = "0x612200", Offset = "0x611000", VA = "0x10612200")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009E8A")]
    [Address(RVA = "0x611260", Offset = "0x610060", VA = "0x10611260")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6009E8B")]
    [Address(RVA = "0x6110D0", Offset = "0x60FED0", VA = "0x106110D0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6009E8C")]
    [Address(RVA = "0x611B00", Offset = "0x610900", VA = "0x10611B00")]
    private IEnumerator RefreshAsync(bool immediate = false) => (IEnumerator) null;

    [Token(Token = "0x6009E8D")]
    [Address(RVA = "0x613180", Offset = "0x611F80", VA = "0x10613180")]
    private void Update()
    {
    }

    [Token(Token = "0x6009E8E")]
    [Address(RVA = "0x610F70", Offset = "0x60FD70", VA = "0x10610F70")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009E8F")]
    [Address(RVA = "0x612FC0", Offset = "0x611DC0", VA = "0x10612FC0")]
    public void Setup(int index)
    {
    }

    [Token(Token = "0x6009E90")]
    [Address(RVA = "0x5A4130", Offset = "0x5A2F30", VA = "0x105A4130")]
    public void Setup(UnitData _data)
    {
    }

    [Token(Token = "0x6009E91")]
    [Address(RVA = "0x612C80", Offset = "0x611A80", VA = "0x10612C80")]
    private void SetPreviewVisible(bool visible)
    {
    }

    [Token(Token = "0x6009E92")]
    [Address(RVA = "0x6129B0", Offset = "0x6117B0", VA = "0x106129B0")]
    private void ReloadPreviewModels()
    {
    }

    [Token(Token = "0x6009E93")]
    [Address(RVA = "0x611E10", Offset = "0x610C10", VA = "0x10611E10")]
    private void RefreshStatus()
    {
    }

    [Token(Token = "0x6009E94")]
    [Address(RVA = "0x611CF0", Offset = "0x610AF0", VA = "0x10611CF0")]
    private void RefreshLeaderSkillInfo()
    {
    }

    [Token(Token = "0x6009E95")]
    [Address(RVA = "0x611B70", Offset = "0x610970", VA = "0x10611B70")]
    private void RefreshJobInfo()
    {
    }

    [Token(Token = "0x6009E96")]
    [Address(RVA = "0x6114D0", Offset = "0x6102D0", VA = "0x106114D0")]
    private void RefreshAbilitList()
    {
    }

    [Token(Token = "0x6009E97")]
    [Address(RVA = "0x610C00", Offset = "0x60FA00", VA = "0x10610C00")]
    private UnitData CreateUnitData(UnitParam uparam) => (UnitData) null;

    [Token(Token = "0x6009E98")]
    [Address(RVA = "0x610F10", Offset = "0x60FD10", VA = "0x10610F10")]
    private void FadeUnitImage(float alphastart, float alphaend, float duration)
    {
    }

    [Token(Token = "0x6009E99")]
    [Address(RVA = "0x612E70", Offset = "0x611C70", VA = "0x10612E70")]
    private void SetUnitImageAlpha(float alpha)
    {
    }

    [Token(Token = "0x6009E9A")]
    [Address(RVA = "0x612190", Offset = "0x610F90", VA = "0x10612190")]
    private IEnumerator RefreshUnitImage() => (IEnumerator) null;

    [Token(Token = "0x6009E9B")]
    [Address(RVA = "0x613360", Offset = "0x612160", VA = "0x10613360")]
    public GachaResultUnitDetail()
    {
    }
  }
}
