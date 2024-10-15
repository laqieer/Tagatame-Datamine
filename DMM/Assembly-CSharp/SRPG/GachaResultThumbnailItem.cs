// Decompiled with JetBrains decompiler
// Type: SRPG.GachaResultThumbnailItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002445")]
  [AddComponentMenu("UI/GachaResultThumbnailItem")]
  public class GachaResultThumbnailItem : MonoBehaviour
  {
    [Token(Token = "0x400A45B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject m_UnitIcon;
    [Token(Token = "0x400A45C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject m_ItemIcon;
    [Token(Token = "0x400A45D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject m_ArtifactIcon;
    [Token(Token = "0x400A45E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject m_ConceptCardIcon;
    [Token(Token = "0x400A45F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject m_CrystalIcon;
    [Token(Token = "0x400A460")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject m_ChangePieceCoin;
    [Token(Token = "0x400A461")]
    [FieldOffset(Offset = "0x24")]
    private GameObject mCurrentIconObj;

    [Token(Token = "0x1700161F")]
    public GameObject CurrentIcon
    {
      [Token(Token = "0x6009E3E"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x6009E3F")]
    [Address(RVA = "0x60BFB0", Offset = "0x60ADB0", VA = "0x1060BFB0")]
    public bool Setup(GachaDropData drop, int index) => new bool();

    [Token(Token = "0x6009E40")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaResultThumbnailItem()
    {
    }
  }
}
