// Decompiled with JetBrains decompiler
// Type: SRPG.RuneIcon
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
  [Token(Token = "0x20029A9")]
  [AddComponentMenu("UI/Rune/RuneIcon")]
  public class RuneIcon : MonoBehaviour
  {
    [Token(Token = "0x400C9D0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Button mButton;
    [Token(Token = "0x400C9D1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image mCheckIcon;
    [Token(Token = "0x400C9D2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ImageSpriteSheet mSetType;
    [Token(Token = "0x400C9D3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ImageArray mEvoImage;
    [Token(Token = "0x400C9D4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ImageArray mEnhanceImage;
    [Token(Token = "0x400C9D5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mOwnerIconParent;
    [Token(Token = "0x400C9D6")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Image mOwnerIcon;
    [Token(Token = "0x400C9D7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image mSelectObject;
    [Token(Token = "0x400C9D8")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text mStatusCount;
    [Token(Token = "0x400C9D9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mFavorite;
    [Token(Token = "0x400C9DA")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private bool mIsReplaseRune;
    [Token(Token = "0x400C9DB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mOrganization;
    [Token(Token = "0x400C9DC")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mBeforeUsed;
    [Token(Token = "0x400C9DD")]
    [FieldOffset(Offset = "0x40")]
    private BindRuneData mRune;
    [Token(Token = "0x400C9DE")]
    private const float CHANGE_INTERVAL = 2f;
    [Token(Token = "0x400C9DF")]
    [FieldOffset(Offset = "0x44")]
    private List<GameObject> mBadgeObjects;
    [Token(Token = "0x400C9E0")]
    [FieldOffset(Offset = "0x48")]
    private float mStartupTime;
    [Token(Token = "0x400C9E1")]
    [FieldOffset(Offset = "0x4C")]
    private int mBadgeIndex;

    [Token(Token = "0x17001991")]
    public BindRuneData Rune
    {
      [Token(Token = "0x600BD17"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (BindRuneData) null;
      }
    }

    [Token(Token = "0x600BD18")]
    [Address(RVA = "0x84C8D0", Offset = "0x84B6D0", VA = "0x1084C8D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BD19")]
    [Address(RVA = "0x84D920", Offset = "0x84C720", VA = "0x1084D920")]
    private void Update()
    {
    }

    [Token(Token = "0x600BD1A")]
    [Address(RVA = "0x84D7E0", Offset = "0x84C5E0", VA = "0x1084D7E0")]
    public void Setup(BindRuneData rune, bool is_owner_disable = false)
    {
    }

    [Token(Token = "0x600BD1B")]
    [Address(RVA = "0x84D1F0", Offset = "0x84BFF0", VA = "0x1084D1F0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BD1C")]
    [Address(RVA = "0x84D130", Offset = "0x84BF30", VA = "0x1084D130")]
    private void RefreshSetType()
    {
    }

    [Token(Token = "0x600BD1D")]
    [Address(RVA = "0x84CC70", Offset = "0x84BA70", VA = "0x1084CC70")]
    private void RefreshEvoImage()
    {
    }

    [Token(Token = "0x600BD1E")]
    [Address(RVA = "0x84CBB0", Offset = "0x84B9B0", VA = "0x1084CBB0")]
    private void RefreshEnhanceImage()
    {
    }

    [Token(Token = "0x600BD1F")]
    [Address(RVA = "0x84CE10", Offset = "0x84BC10", VA = "0x1084CE10")]
    private void RefreshOwnerIcon()
    {
    }

    [Token(Token = "0x600BD20")]
    [Address(RVA = "0x84CA90", Offset = "0x84B890", VA = "0x1084CA90")]
    private void RefreshCheckIcon()
    {
    }

    [Token(Token = "0x600BD21")]
    [Address(RVA = "0x84D0B0", Offset = "0x84BEB0", VA = "0x1084D0B0")]
    public void RefreshSelectFrame()
    {
    }

    [Token(Token = "0x600BD22")]
    [Address(RVA = "0x84C920", Offset = "0x84B720", VA = "0x1084C920")]
    public UnitData GetOwner() => (UnitData) null;

    [Token(Token = "0x600BD23")]
    [Address(RVA = "0x84CB10", Offset = "0x84B910", VA = "0x1084CB10")]
    public void RefreshEnableParam(bool enable)
    {
    }

    [Token(Token = "0x600BD24")]
    [Address(RVA = "0x84C9F0", Offset = "0x84B7F0", VA = "0x1084C9F0")]
    public void RefreshBaseStatusCount()
    {
    }

    [Token(Token = "0x600BD25")]
    [Address(RVA = "0x84CD40", Offset = "0x84BB40", VA = "0x1084CD40")]
    private void RefreshFavorite()
    {
    }

    [Token(Token = "0x600BD26")]
    [Address(RVA = "0x84D760", Offset = "0x84C560", VA = "0x1084D760")]
    public void SetOrganization(bool flag)
    {
    }

    [Token(Token = "0x600BD27")]
    [Address(RVA = "0x84D710", Offset = "0x84C510", VA = "0x1084D710")]
    public void SetBeforeUsed(bool isValue)
    {
    }

    [Token(Token = "0x600BD28")]
    [Address(RVA = "0x84D7B0", Offset = "0x84C5B0", VA = "0x1084D7B0")]
    private void SetupBadge()
    {
    }

    [Token(Token = "0x600BD29")]
    [Address(RVA = "0x84D820", Offset = "0x84C620", VA = "0x1084D820")]
    private void UpdateBadge()
    {
    }

    [Token(Token = "0x600BD2A")]
    [Address(RVA = "0x84C950", Offset = "0x84B750", VA = "0x1084C950")]
    private void HideBadgeAll()
    {
    }

    [Token(Token = "0x600BD2B")]
    [Address(RVA = "0x84D930", Offset = "0x84C730", VA = "0x1084D930")]
    public RuneIcon()
    {
    }
  }
}
