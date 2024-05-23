using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using TMPro;

public class RegisterScript : MonoBehaviour
{
    public TMP_InputField emailInput;
    public TMP_InputField firstNameInput;
    public TMP_InputField lastNameInput;
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public TMP_InputField confirmPasswordInput;

    public void ButtonRegister()
    {
        StartCoroutine(RegisterUser());
    }

    private IEnumerator RegisterUser()
    {
        // Construir la URL del endpoint
        string url = "http://localhost:3000/api/usuario/crear";

        // Crear un objeto de forma para los datos del usuario
        WWWForm form = new WWWForm();
        form.AddField("correo", emailInput.text);
        form.AddField("nombre", firstNameInput.text);
        form.AddField("apellido", lastNameInput.text);
        form.AddField("nombreUsuario", usernameInput.text);
        form.AddField("contraseña", passwordInput.text);

        // Crear la solicitud HTTP
        using (UnityWebRequest request = UnityWebRequest.Post(url, form))
        {
            // Enviar la solicitud
            yield return request.SendWebRequest();

            // Verificar si la solicitud fue exitosa
            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Registro exitoso");
            }
            else
            {
                Debug.LogError("Error al registrar: " + request.error);
            }
        }
    }
}

