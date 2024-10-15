// Decompiled with JetBrains decompiler
// Type: SRPG.RenderForWindows
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E2E")]
  [AddComponentMenu("Camera/RenderForWindows")]
  public class RenderForWindows : MonoBehaviour
  {
    [Token(Token = "0x4002B05")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RenderForWindows.eTargetType target_type;
    [Token(Token = "0x4002B06")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private UnityEngine.Camera target_camera;
    [Token(Token = "0x4002B07")]
    private const string MATERIAL_SHADER_NAME = "Unlit/Texture";
    [Token(Token = "0x4002B08")]
    private const string RAW_IMAGE_NAME = "RawImage";
    [Token(Token = "0x4002B09")]
    private const string CANVAS_NAME = "Canvas";
    [Token(Token = "0x4002B0A")]
    [FieldOffset(Offset = "0x14")]
    private int canvas_sort_order;
    [Token(Token = "0x4002B0B")]
    [FieldOffset(Offset = "0x18")]
    private bool is_enable;
    [Token(Token = "0x4002B0C")]
    [FieldOffset(Offset = "0x1C")]
    private RenderTexture render_texture;
    [Token(Token = "0x4002B0D")]
    [FieldOffset(Offset = "0x20")]
    private Canvas canvas;
    [Token(Token = "0x4002B0E")]
    [FieldOffset(Offset = "0x24")]
    private RawImage image;
    [Token(Token = "0x4002B0F")]
    [FieldOffset(Offset = "0x28")]
    private RectTransform img_rect_transform;
    [Token(Token = "0x4002B10")]
    [FieldOffset(Offset = "0x2C")]
    private bool is_dont_create_render_texture;

    [Token(Token = "0x17000436")]
    public bool IsDontCreteRenderTexture
    {
      [Token(Token = "0x6003A73"), Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", VA = "0x104A9DB0")] set
      {
      }
    }

    [Token(Token = "0x6003A74")]
    [Address(RVA = "0x10DDFF0", Offset = "0x10DCDF0", VA = "0x110DDFF0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003A75")]
    [Address(RVA = "0x10DE8A0", Offset = "0x10DD6A0", VA = "0x110DE8A0")]
    private void Start()
    {
    }

    [Token(Token = "0x6003A76")]
    [Address(RVA = "0x10DE710", Offset = "0x10DD510", VA = "0x110DE710")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6003A77")]
    [Address(RVA = "0x10DE870", Offset = "0x10DD670", VA = "0x110DE870")]
    public void SetTargetType(RenderForWindows.eTargetType _type, UnityEngine.Camera _target_camera = null)
    {
    }

    [Token(Token = "0x6003A78")]
    [Address(RVA = "0x10DE830", Offset = "0x10DD630", VA = "0x110DE830")]
    public void SetRenderTexture(RenderTexture _render_texture)
    {
    }

    [Token(Token = "0x6003A79")]
    [Address(RVA = "0x10DE530", Offset = "0x10DD330", VA = "0x110DE530")]
    private void Init()
    {
    }

    [Token(Token = "0x6003A7A")]
    [Address(RVA = "0x10DE460", Offset = "0x10DD260", VA = "0x110DE460")]
    private RenderTexture CreateRenderTexture(int _width, int _height) => (RenderTexture) null;

    [Token(Token = "0x6003A7B")]
    [Address(RVA = "0x10DE1C0", Offset = "0x10DCFC0", VA = "0x110DE1C0")]
    private Canvas CreateCanvas() => (Canvas) null;

    [Token(Token = "0x6003A7C")]
    [Address(RVA = "0x10DE2B0", Offset = "0x10DD0B0", VA = "0x110DE2B0")]
    private RawImage CreateRawImage(Transform _parent, float _width, float _height)
    {
      return (RawImage) null;
    }

    [Token(Token = "0x6003A7D")]
    [Address(RVA = "0x10DE8C0", Offset = "0x10DD6C0", VA = "0x110DE8C0")]
    public RenderForWindows()
    {
    }

    [Token(Token = "0x2000E2F")]
    public enum eTargetType
    {
      [Token(Token = "0x4002B12")] MAIN_CAMERA,
      [Token(Token = "0x4002B13")] SELECTED,
    }
  }
}
