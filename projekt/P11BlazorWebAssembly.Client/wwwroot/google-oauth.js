let authenticationStateProviderInstance = null;

function googleInitialize(clientId, authenticationStateProvider)
{
    authenticationStateProviderInstance = authenticationStateProvider;
    google.accounts.id.initialize({ client_id: clientId, callback: callback });
}

function googlePrompt()
{
    console.log("googlePrompt");
    google.accounts.id.prompt((notification) =>
    {
        if (notification.isNotDisplayed() || notification.isSkippedMoment())
        {
            console.info(notification.getNotDisplayedReason());
            console.info(notification.getSkippedReason());
        }
    });
}

function callback(googleResponse)
{
    authenticationStateProviderInstance.invokeMethodAsync("GoogleLogin", { ClientId: googleResponse.clientId, SelectedBy: googleResponse.select_by, Credential: googleResponse.credential });   
}