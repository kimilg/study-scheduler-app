import React from "react";
import { NavLink } from "react-router-dom";
import { Button, Container, Divider, Icon, Menu } from "semantic-ui-react";

export default function NavBar() {
    return (
        <Menu fixed='top' inverted>
            <Container>
                <Menu.Item as={NavLink} to='/' exact>
                    <Icon name='flag checkered' />
                    Scheduler App Home
                </Menu.Item>
                <Menu.Item as={NavLink} to='/details'>
                    Today schedule
                </Menu.Item>
            </Container>
        </Menu>

    )
}