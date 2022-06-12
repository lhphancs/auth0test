# auth0test
This Auth0 asp.net application uses the guide in the "Quick Start" displayed in Auth0

## Auth0 Setup
1) Go to Auth0 dashboard and click "Create Application"
2) Select "Regular Web Application".
3) Go into the created application "Settings" tab, and set two things
	a) Allowed Callback URLs = http://localhost:3000
	b) Allowed Logout URLs = http://localhost:3000
4) Go the "APIs" tab, and "Create Api". Fill out fields. The "Identifier" will be used in future appSettings step.
5) Set Users and Roles
	a) The user can be generated upon logging via the app, or creating a user from the app after clicking "Log In" on the webpage. You will see users in the "Users" tab afterwards.
	b) Create a role called "admin". Add the newly created admin role to the user.
	
## Set app setting values on Web.config
All of these values can be found in the auth0's webpage application's "Settings" tab, except for the "auth0:Audience" value. 
The "auth0:Audience" value can be found in the auth0 webpage's APIs tab from "Auth0 Setup" earlier in step 4. It can be found in  the API's setting in the "Identifier" field.
That is, you will have to go to the "APIs" tab, click your created API's settings, click the "Settings" tab, and find the value for "Identifier" (See step 4).

<add key="auth0:Domain" value="{}" />
<add key="auth0:ClientId" value="{}" />
<add key="auth0:ClientSecret" value="{}" />
<add key="auth0:Audience" value="{}" />