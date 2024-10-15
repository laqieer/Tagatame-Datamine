// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureBookItemBuff
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F73")]
  [AddComponentMenu("UI/Adventure/AdventureBookItemBuff")]
  public class AdventureBookItemBuff : MonoBehaviour
  {
    [Token(Token = "0x40084C7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject BuffCurrentlyBase;
    [Token(Token = "0x40084C8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject BuffNextBase;
    [Token(Token = "0x40084C9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject BuffNoneBase;
    [Token(Token = "0x40084CA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Space(5f)]
    private Text TextBuffInformName;
    [Token(Token = "0x40084CB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject TextBuffLevelObject;
    [Token(Token = "0x40084CC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BitmapText TextBuffLevelNum;
    [Token(Token = "0x40084CD")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject TextBuffInformTitle;
    [Token(Token = "0x40084CE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text TextBuffInformExp;
    [Token(Token = "0x40084CF")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text TextNoneBuffExp;
    [Token(Token = "0x40084D0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Space(5f)]
    private GameObject BuffNowBadge;
    [Token(Token = "0x40084D1")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject BuffNextBadge;
    [Token(Token = "0x40084D2")]
    [FieldOffset(Offset = "0x38")]
    private AdventureBookWindow mParent;
    [Token(Token = "0x40084D3")]
    [FieldOffset(Offset = "0x3C")]
    private int mIndex;

    [Token(Token = "0x17001288")]
    public AdventureBookWindow Parent
    {
      [Token(Token = "0x6008135"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (AdventureBookWindow) null;
      }
    }

    [Token(Token = "0x17001289")]
    public int Index
    {
      [Token(Token = "0x6008136"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008137")]
    [Address(RVA = "0x41BC00", Offset = "0x41AA00", VA = "0x1041BC00")]
    public void Setup(
      AdventureBookWindow parent,
      int index,
      int level,
      AdventureAreaParam.QuestInfo quest_info,
      UnityAction action)
    {
    }

    [Token(Token = "0x6008138")]
    [Address(RVA = "0x41B900", Offset = "0x41A700", VA = "0x1041B900")]
    public void DispLevel(
      AdventureBookWindow parent,
      int index,
      int level,
      AdventureAreaParam.QuestInfo quest_info,
      UnityAction action)
    {
    }

    [Token(Token = "0x6008139")]
    [Address(RVA = "0x41B630", Offset = "0x41A430", VA = "0x1041B630")]
    public void DispLevelZero(
      AdventureBookWindow parent,
      int index,
      int level,
      UnityAction action)
    {
    }

    [Token(Token = "0x600813A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdventureBookItemBuff()
    {
    }

    [Token(Token = "0x2001F74")]
    private enum BuffBadgeState
    {
      [Token(Token = "0x40084D5")] BUFF_ACTIVE,
      [Token(Token = "0x40084D6")] BUFF_NONE,
    }
  }
}
