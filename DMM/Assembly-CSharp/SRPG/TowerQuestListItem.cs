// Decompiled with JetBrains decompiler
// Type: SRPG.TowerQuestListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B52")]
  [AddComponentMenu("UI/TowerQuestListItem")]
  public class TowerQuestListItem : MonoBehaviour
  {
    [Token(Token = "0x400D3E7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mBody;
    [Token(Token = "0x400D3E8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mCleared;
    [Token(Token = "0x400D3E9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mLocked;
    [Token(Token = "0x400D3EA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Graphic mGraphicRoot;
    [Token(Token = "0x400D3EB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ImageArray[] mBanner;
    [Token(Token = "0x400D3EC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mCursor;
    [Token(Token = "0x400D3ED")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mText;
    [Token(Token = "0x400D3EE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text m_FloorText;
    [Token(Token = "0x400D3EF")]
    [FieldOffset(Offset = "0x2C")]
    public CanvasRenderer Source;
    [Token(Token = "0x400D3F0")]
    private const string FLOOR_NO_PREFIX = "floorNo_";
    [Token(Token = "0x400D3F1")]
    [FieldOffset(Offset = "0x30")]
    private Color UnknownColor;
    [Token(Token = "0x400D3F2")]
    [FieldOffset(Offset = "0x40")]
    private RectTransform mBodyTransform;
    [Token(Token = "0x400D3F3")]
    [FieldOffset(Offset = "0x44")]
    private TowerQuestListItem.Type now_type;

    [Token(Token = "0x17001A46")]
    public RectTransform rectTransform
    {
      [Token(Token = "0x600C65E"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (RectTransform) null;
      }
      [Token(Token = "0x600C65F"), Address(RVA = "0x288230", Offset = "0x287030", VA = "0x10288230")] private set
      {
      }
    }

    [Token(Token = "0x17001A47")]
    public ImageArray[] Banner
    {
      [Token(Token = "0x600C660"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (ImageArray[]) null;
      }
    }

    [Token(Token = "0x600C661")]
    [Address(RVA = "0x8EE890", Offset = "0x8ED690", VA = "0x108EE890")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C662")]
    [Address(RVA = "0x8EE940", Offset = "0x8ED740", VA = "0x108EE940")]
    public void OnFocus(bool value)
    {
    }

    [Token(Token = "0x600C663")]
    [Address(RVA = "0x8EEA10", Offset = "0x8ED810", VA = "0x108EEA10")]
    private void SetVisible(TowerQuestListItem.Type type)
    {
    }

    [Token(Token = "0x600C664")]
    [Address(RVA = "0x8EE9F0", Offset = "0x8ED7F0", VA = "0x108EE9F0")]
    public void SetNowImage()
    {
    }

    [Token(Token = "0x600C665")]
    [Address(RVA = "0x8EED10", Offset = "0x8EDB10", VA = "0x108EED10")]
    public void UpdateParam(TowerFloorParam param, int floorNo)
    {
    }

    [Token(Token = "0x600C666")]
    [Address(RVA = "0x8EEF60", Offset = "0x8EDD60", VA = "0x108EEF60")]
    public TowerQuestListItem()
    {
    }

    [Token(Token = "0x2002B53")]
    private enum Type
    {
      [Token(Token = "0x400D3F6")] Locked,
      [Token(Token = "0x400D3F7")] Cleared,
      [Token(Token = "0x400D3F8")] Current,
      [Token(Token = "0x400D3F9")] Unknown,
      [Token(Token = "0x400D3FA")] TypeEnd,
    }
  }
}
