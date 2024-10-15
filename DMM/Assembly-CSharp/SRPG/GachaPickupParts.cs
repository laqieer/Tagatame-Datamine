// Decompiled with JetBrains decompiler
// Type: SRPG.GachaPickupParts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200240E")]
  [AddComponentMenu("UI/Gacha/GachaPickupParts")]
  public class GachaPickupParts : MonoBehaviour
  {
    [Token(Token = "0x400A303")]
    [FieldOffset(Offset = "0xC")]
    [Header("切り替え画像オブジェクト")]
    [SerializeField]
    private RawImage m_Image;

    [Token(Token = "0x170015DC")]
    public RawImage Image
    {
      [Token(Token = "0x6009CF5"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (RawImage) null;
      }
    }

    [Token(Token = "0x6009CF6")]
    [Address(RVA = "0x602930", Offset = "0x601730", VA = "0x10602930")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009CF7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaPickupParts()
    {
    }
  }
}
